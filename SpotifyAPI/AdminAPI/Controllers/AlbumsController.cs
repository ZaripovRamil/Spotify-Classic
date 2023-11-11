using AdminAPI.Features.Albums;
using AdminAPI.Features.Albums.Create;
using DatabaseServices.Repositories;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Models.Configuration;
using Models.DTO.BackToFront.Full;
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
    private readonly HttpClient _clientToSearch;
    private readonly IMediator _mediator;

    public AlbumsController(IOptions<Hosts> hostsOptions, IAlbumRepository albumRepository,
        IAlbumDeleteHandler albumDeleteHandler, IAlbumUpdateHandler albumUpdateHandler, IMediator mediator)
    {
        _albumRepository = albumRepository;
        _albumDeleteHandler = albumDeleteHandler;
        _albumUpdateHandler = albumUpdateHandler;
        _mediator = mediator;
        _clientToSearch = new HttpClient
            { BaseAddress = new Uri($"http://{hostsOptions.Value.SearchApi}/search") };
    }

    [HttpGet("get/{id:guid}")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        var album = await _albumRepository.GetByIdAsync(id.ToString());
        return album is null ? new JsonResult(null) : new JsonResult(new AlbumFull(album));
    }

    [HttpPost("add")]
    public async Task<IActionResult> AddAsync([FromForm] RequestDto dto)
    {
        var command = new Command(dto.Name, dto.AuthorId, dto.AlbumType, dto.ReleaseYear, Guid.NewGuid(),
            dto.PreviewFile);
        var res = await _mediator.Send(command);
        if (res.Value!.IsSuccessful)
            return new JsonResult(res.Value);

        return BadRequest(res.Value);
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
}