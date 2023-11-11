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
using Models.Entities;

namespace AdminAPI.Controllers;

[Authorize(Roles = "Admin")]
[ApiController]
[Route("[controller]")]
public class AlbumsController : Controller
{
    private readonly IAlbumRepository _albumRepository;
    private readonly IAlbumDeleteHandler _albumDeleteHandler;
    private readonly IAlbumUpdateHandler _albumUpdateHandler;
    private readonly IAlbumCreateHandler _albumCreateHandler;
    private readonly HttpClient _clientToSearch;
    private readonly HttpClient _clientToStatic;

    public AlbumsController(IOptions<Hosts> hostsOptions, IAlbumRepository albumRepository,
        IAlbumDeleteHandler albumDeleteHandler, IAlbumUpdateHandler albumUpdateHandler,
        IAlbumCreateHandler albumCreateHandler)
    {
        _albumRepository = albumRepository;
        _albumDeleteHandler = albumDeleteHandler;
        _albumUpdateHandler = albumUpdateHandler;
        _albumCreateHandler = albumCreateHandler;
        _clientToSearch = new HttpClient
            { BaseAddress = new Uri($"http://{hostsOptions.Value.SearchApi}/search") };
        _clientToStatic = new HttpClient
            { BaseAddress = new Uri($"http://{hostsOptions.Value.StaticApi}/previews/") };
    }

    [HttpGet("get/{id:guid}")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        var album = await _albumRepository.GetByIdAsync(id.ToString());
        return album is null ? new JsonResult(null) : new JsonResult(new AlbumFull(album));
    }

    // actually garbage, but looks not so bad now
    [HttpPost("add")]
    public async Task<IActionResult> AddAsync([FromForm] AlbumCreationDataWithFile creationDataWithFile)
    {
        var creationData = (AlbumCreationData)creationDataWithFile;
        var albumCreationResult = await AddToDbAsync(creationData);
        if (!albumCreationResult.IsSuccessful)
            return BadRequest(albumCreationResult);

        var album = await _albumRepository.GetByIdAsync(albumCreationResult.AlbumId!);
        var staticResponse =
            await UploadContentToStaticAsync(creationDataWithFile.PreviewFile, album!.PreviewId);
        if (staticResponse.IsSuccessStatusCode) return new JsonResult(albumCreationResult);

        // if static API rejected uploading, delete album from database. what if this fails too? cry, i suppose.
        await DeleteAsync(Guid.Parse(albumCreationResult.AlbumId!));
        return BadRequest(new AlbumCreationResult
        {
            IsSuccessful = false,
            ResultMessage = await staticResponse.Content.ReadAsStringAsync()
        });
    }

    private async Task<AlbumCreationResult> AddToDbAsync(AlbumCreationData creationData)
    {
        return await _albumCreateHandler.CreateAsync(creationData);
    }

    private async Task<HttpResponseMessage> UploadContentToStaticAsync(IFormFile album, string previewId)
    {
        var formData = new MultipartFormDataContent();
        var albumContent = new StreamContent(album.OpenReadStream());
        formData.Add(albumContent, "file", $"{previewId}.jpg");

        return await _clientToStatic.PostAsync("upload", formData);
    }

    [HttpDelete("delete/{id:guid}")]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        return new JsonResult(await _albumDeleteHandler.DeleteAsync(id.ToString()));
    }

    [HttpPut("update/{id:guid}")]
    public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] AlbumUpdateData albumUpdateData)
    {
        return new JsonResult(await _albumUpdateHandler.UpdateAsync(id.ToString(), albumUpdateData));
    }

    [HttpGet("get")]
    public IActionResult GetWithFilters([FromQuery] string? albumType, [FromQuery] int? tracksMin,
        [FromQuery] int? tracksMax, [FromQuery] int? maxCount, [FromQuery] string? sortBy, [FromQuery] string? search)
    {
        var albums = _albumRepository.GetAll().AsEnumerable().Where(a =>
                (albumType == null ||
                 string.Equals(a.Type.ToString(), albumType, StringComparison.CurrentCultureIgnoreCase)) &&
                (tracksMin == null || a.Tracks.Count >= tracksMin.Value) &&
                (tracksMax == null || a.Tracks.Count <= tracksMax.Value) &&
                (search == null || a.Name.ToLower().Contains(search.ToLower())))
            .Take(new Range(0, maxCount ?? ^1))
            .Select(a => new AlbumFull(a))
            .ToList();
        Func<AlbumFull, IComparable> sort = sortBy?.ToLower() switch
        {
            "id" => album => album.Id,
            "name" => album => album.Name,
            "author" => album => album.Author.Name,
            "type" => album => album.Type,
            _ => album => album.Name
        };
        return new JsonResult(albums.OrderBy(sort));
    }

    [HttpGet("search")]
    public async Task<IActionResult> FindAlbumByAuthorName([FromQuery] string? query)
    {
        var albums = await _clientToSearch.GetFromJsonAsync<IEnumerable<Album>>(
            $"albums/by/author?query={query}");
        return new JsonResult(albums?.Select(a => new AlbumFull(a)));
    }
}