using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace SearchAPI.Controllers;
[ApiController]
[Route("Search")]
public class SearchController:Controller
{
    private readonly IMediator _mediator;

    public SearchController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Search([FromQuery]string? query)
    {
        var q = new Features.GlobalSearch.Query(query ?? string.Empty);
        var res = await _mediator.Send(q);
        return res.IsSuccessful ? Ok(res.Value) : BadRequest(res.Errors);
    }

    [HttpGet("users")]
    public async Task<IActionResult> SearchUsers([FromQuery]string? query)
    {
        var q = new Features.SearchUsers.Query(query ?? string.Empty);
        var res = await _mediator.Send(q);
        return res.IsSuccessful ? Ok(res.Value) : BadRequest(res.Errors);
    }

    [HttpGet("albums")]
    public async Task<IActionResult> SearchAlbums([FromQuery]string? query)
    {
        var q = new Features.SearchAlbums.Query(query ?? string.Empty);
        var res = await _mediator.Send(q);
        return res.IsSuccessful ? Ok(res.Value) : BadRequest(res.Errors);
    }

    [HttpGet("albums/by/author")]
    public async Task<IActionResult> SearchAlbumsByAuthor([FromQuery] string? query)
    {
        var q = new Features.SearchAlbumsByAuthor.Query(query ?? string.Empty);
        var res = await _mediator.Send(q);
        return res.IsSuccessful ? Ok(res.Value) : BadRequest(res.Errors);
    }

    [HttpGet("authors/by/user")]
    public async Task<IActionResult> SearchAuthorsByUser([FromQuery] string? query)
    {
        var q = new Features.SearchAuthorsByUser.Query(query ?? string.Empty);
        var res = await _mediator.Send(q);
        return res.IsSuccessful ? Ok(res.Value) : BadRequest(res.Errors);
    }

    [HttpGet("tracks/by/albumAuthor")]
    public async Task<IActionResult> SearchTracksByAlbumOrAuthor([FromQuery] string? query)
    {
        var q = new Features.SearchTracksByAlbumOrAuthor.Query(query ?? string.Empty);
        var res = await _mediator.Send(q);
        return res.IsSuccessful ? Ok(res.Value) : BadRequest(res.Errors);
    }
}