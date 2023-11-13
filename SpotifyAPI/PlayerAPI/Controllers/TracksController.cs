using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace PlayerAPI.Controllers;

// [Authorize(Roles = "Free,Premium,Admin")]
[ApiController]
[Route("[controller]")]
public class TracksController : Controller
{
    private readonly IMediator _mediator;
    public TracksController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("get")]
    public async Task<IActionResult> GetAllAsync()
    {
        var q = new Features.GetTracks.Query();
        var res = await _mediator.Send(q);
        return res.IsSuccessful ?  new JsonResult(res.Value!.Tracks) : BadRequest(res.Errors);
    }

    [HttpGet("get/{id}")]
    public async Task<IActionResult> GetByIdAsStreamAsync(string id)
    {
        var q = new Features.GetTrackById.Query(id, User);
        var res = await _mediator.Send(q);
        return res.IsSuccessful ? new FileStreamResult(res.Value!, "application/octet-stream") : BadRequest(res.Errors);
    }
}