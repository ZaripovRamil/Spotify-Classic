using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace PlayerAPI.Controllers;

[Authorize(Roles = "Free,Premium,Admin")]
[ApiController]
[Route("[controller]")]
public class AlbumsController : Controller
{
    private readonly IMediator _mediator;

    public AlbumsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("get")]
    public async Task<IActionResult> GetAllAsync()
    {
        var q = new Features.GetAlbums.Query();
        var res = await _mediator.Send(q);
        return res.IsSuccessful ? new JsonResult(res.Value!.Albums) : BadRequest(res.Errors);
    }

    [HttpGet("get/{id}")]
    public async Task<IActionResult> GetByIdAsync(string id)
    {
        var q = new Features.GetAlbumById.Query(id);
        var res = await _mediator.Send(q);
        return res.IsSuccessful ? new JsonResult(res.Value!) : BadRequest(res.Errors);
    }
}