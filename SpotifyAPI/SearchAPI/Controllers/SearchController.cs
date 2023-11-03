using MediatR;
using Microsoft.AspNetCore.Mvc;
using SearchAPI.Services;

namespace SearchAPI.Controllers;
[ApiController]
[Route("Search")]
public class SearchController:Controller
{
    private readonly ISearchEngine _searchEngine;
    private readonly IMediator _mediator;

    public SearchController(ISearchEngine searchEngine, IMediator mediator)
    {
        _searchEngine = searchEngine;
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Search([FromQuery]string? query)
    {
        return Ok(await _searchEngine.SearchAsync(query?? ""));
    }

    [HttpGet("users")]
    public async Task<IActionResult> SearchUsers([FromQuery]string? query)
    {
        var q = new Features.SearchUsers.Query(query ?? "");
        var res = await _mediator.Send(q);
        return res.IsSuccessful ? Ok(res.Value) : BadRequest(res.Errors);
    }

    [HttpGet("albums")]
    public async Task<IActionResult> SearchAlbums([FromQuery]string? query)
    {
        return Ok(await _searchEngine.SearchAlbumsAsync(query?? ""));
    }

    [HttpGet("albums/by/author")]
    public async Task<IActionResult> SearchAlbumsByAuthor([FromQuery] string? query)
    {
        return Ok(await _searchEngine.SearchAlbumsByAuthorsAsync(query ?? ""));
    }

    [HttpGet("authors/by/user")]
    public async Task<IActionResult> SearchAuthorsByUser([FromQuery] string? query)
    {
        return Ok(await _searchEngine.SearchAuthorsByUserAsync(query ?? ""));
    }

    [HttpGet("tracks/by/albumAuthor")]
    public async Task<IActionResult> SearchTracksByAlbumOrAuthor([FromQuery] string? query)
    {
        return Ok(await _searchEngine.SearchTracksByAlbumOrAuthorAsync(query ?? ""));
    }
}