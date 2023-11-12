using DatabaseServices.Repositories;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Models.Configuration;
using Models.DTO.BackToFront.Full;
using Models.Entities;
using AdminAPI.Dto;
using Utils.CQRS;

namespace AdminAPI.Controllers;

[Authorize(Roles = "Admin")]
[ApiController]
[Route("[controller]")]
public class AlbumsController : Controller
{
    private readonly IAlbumRepository _albumRepository;
    private readonly HttpClient _clientToSearch;
    private readonly IMediator _mediator;

    public AlbumsController(IOptions<Hosts> hostsOptions, IAlbumRepository albumRepository, IMediator mediator)
    {
        _albumRepository = albumRepository;
        _mediator = mediator;
        _clientToSearch = new HttpClient
            { BaseAddress = new Uri($"http://{hostsOptions.Value.SearchApi}/search") };
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        var album = await _albumRepository.GetByIdAsync(id.ToString());
        return album is null ? new JsonResult(null) : new JsonResult(new AlbumFull(album));
    }

    [HttpPost]
    public async Task<IActionResult> AddAsync([FromForm] Features.Albums.Create.RequestDto dto)
    {
        var command = new Features.Albums.Create.Command(dto.Name, dto.AuthorId, dto.AlbumType, dto.ReleaseYear,
            Guid.NewGuid(), dto.PreviewFile);
        var res = await _mediator.Send(command);
        return res.IsSuccessful switch
        {
            false => BadRequest(new Features.Albums.Create.ResultDto(false, res.JoinErrors(), null)),
            true when res.Value!.IsSuccessful => new JsonResult(res.Value),
            _ => BadRequest(res.Value)
        };
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        var command = new Features.Albums.Delete.Command(id);
        return await SendResponse(command);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAsync(Features.Albums.Update.Command command)
    {
        return await SendResponse(command);
    }

    [HttpGet]
    public async Task<IActionResult> GetWithFilters([FromQuery] string? albumType, [FromQuery] int? tracksMin,
        [FromQuery] int? tracksMax, [FromQuery] int? maxCount, [FromQuery] string? sortBy, [FromQuery] string? search)
    {
        var albums = await _albumRepository.GetAllAsync().Where(a =>
                (albumType == null ||
                 string.Equals(a.Type.ToString(), albumType, StringComparison.CurrentCultureIgnoreCase)) &&
                (tracksMin == null || a.Tracks.Count >= tracksMin.Value) &&
                (tracksMax == null || a.Tracks.Count <= tracksMax.Value) &&
                (search == null || a.Name.ToLower().Contains(search.ToLower())))
            .Take(maxCount ?? 50)
            .Select(a => new AlbumFull(a))
            .ToListAsync();
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

    private async Task<IActionResult> SendResponse<T>(T request) where T : ICommand<ResultDto>
    {
        var res = await _mediator.Send(request);
        return res.IsSuccessful switch
        {
            false => BadRequest(new ResultDto(false, res.JoinErrors())),
            true when res.Value!.IsSuccessful => new JsonResult(res.Value),
            _ => BadRequest(res.Value)
        };
    }
}