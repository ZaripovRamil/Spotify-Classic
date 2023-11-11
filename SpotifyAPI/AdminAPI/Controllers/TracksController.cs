using AdminAPI.ModelsExtensions;
using DatabaseServices.CommandHandlers.CreateHandlers;
using DatabaseServices.CommandHandlers.DeleteHandlers;
using DatabaseServices.CommandHandlers.UpdateHandlers;
using DatabaseServices.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Models.Configuration;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.BackToFront.Full;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.FrontToBack.EntityUpdateData;

namespace AdminAPI.Controllers;

[Authorize(Roles = "Admin")]
[ApiController]
[Route("[controller]")]
public class TracksController : Controller
{
    private readonly ITrackRepository _trackRepository;
    private readonly ITrackCreateHandler _trackCreateHandler;
    private readonly ITrackUpdateHandler _trackUpdateHandler;
    private readonly ITrackDeleteHandler _trackDeleteHandler;
    private readonly HttpClient _clientToStatic;
    private readonly HttpClient _clientToSearch;

    public TracksController(IOptions<Hosts> hostsOptions, ITrackRepository trackRepository,
        ITrackCreateHandler trackCreateHandler, ITrackDeleteHandler trackDeleteHandler,
        ITrackUpdateHandler trackUpdateHandler)
    {
        _trackRepository = trackRepository;
        _trackCreateHandler = trackCreateHandler;
        _trackDeleteHandler = trackDeleteHandler;
        _trackUpdateHandler = trackUpdateHandler;
        _clientToSearch = new HttpClient
            { BaseAddress = new Uri($"http://{hostsOptions.Value.SearchApi}/search/") };
        _clientToStatic = new HttpClient
            { BaseAddress = new Uri($"http://{hostsOptions.Value.StaticApi}/tracks/") };
    }

    [HttpGet("get/{id:guid}")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        var track = await _trackRepository.GetByIdAsync(id.ToString());
        return new JsonResult(track is null ? null : new TrackFull(track));
    }

    // actually garbage, but looks not so bad now
    [HttpPost("add")]
    public async Task<IActionResult> AddAsync([FromForm] TrackCreationDataWithFile creationDataWithFile)
    {
        var creationData = (TrackCreationData)creationDataWithFile;
        var trackCreationResult = await _trackCreateHandler.CreateAsync(creationData);
        if (!trackCreationResult.IsSuccessful)
            return BadRequest(trackCreationResult);

        var track = await _trackRepository.GetByIdAsync(trackCreationResult.TrackId!);
        if (track is null)
            return BadRequest();
        var trackFull = new TrackFull(track);
        var staticResponse =
            await UploadContentToStaticAsync(creationDataWithFile.TrackFile, Guid.Parse(trackFull.FileId));
        if (staticResponse.IsSuccessStatusCode) return new JsonResult(trackCreationResult);

        // if static API rejected uploading, delete track from database. what if this fails too? cry, i suppose.
        await DeleteAsync(Guid.Parse(trackCreationResult.TrackId!));
        return BadRequest(new TrackCreationResult
        {
            IsSuccessful = false,
            ResultMessage = await staticResponse.Content.ReadAsStringAsync()
        });
    }

    private async Task<HttpResponseMessage> UploadContentToStaticAsync(IFormFile track, Guid trackId)
    {
        var formData = new MultipartFormDataContent();
        var trackContent = new StreamContent(track.OpenReadStream());
        formData.Add(trackContent, "file", $"{trackId}.mp3");

        return await _clientToStatic.PostAsync("upload", formData);
    }

    [HttpDelete("delete/{id:guid}")]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        return new JsonResult(await _trackDeleteHandler.DeleteAsync(id.ToString()));
    }

    [HttpPut("update/{id:guid}")]
    public async Task<IActionResult> UpdateAsync(Guid id, TrackUpdateData trackUpdateData)
    {
        return new JsonResult(await _trackUpdateHandler.UpdateAsync(id.ToString(), trackUpdateData));
    }

    [HttpGet("search")]
    public async Task<IActionResult> FindTrackByAlbumAuthor([FromQuery] string? query)
    {
        var tracks = await _clientToSearch.GetFromJsonAsync<IEnumerable<TrackFull>>(
            $"tracks/by/albumAuthor?query={query}");
        return new JsonResult(tracks);
    }

    [HttpGet("get")]
    public async Task<IActionResult> GetWithFiltersAsync([FromQuery] int? pageSize, [FromQuery] int? pageIndex,
        [FromQuery] string? sortBy, [FromQuery] string? search)
    {
        pageSize ??= 20;
        pageIndex ??= 1;
        var tracks = await _trackRepository.FilterAsync(t =>
                search == null || t.Name.ToLower().Contains(search.ToLower()))
            .Skip(pageSize.Value * (pageIndex.Value - 1))
            .Take(pageSize.Value)
            .Select(t => new TrackFull(t))
            .ToListAsync();
        Func<TrackFull, IComparable> sort = sortBy?.ToLower() switch
        {
            "id" => track => track.Id,
            "name" => track => track.Name,
            "album" => track => track.Album.Name,
            "author" => track => track.Album.Author.Name,
            _ => track => track.Name
        };

        return new JsonResult(tracks.OrderBy(sort));
    }
}