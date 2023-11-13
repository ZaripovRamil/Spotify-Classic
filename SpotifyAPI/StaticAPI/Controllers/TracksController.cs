using MediatR;
using Microsoft.AspNetCore.Mvc;
using StaticAPI.Features.Track.UploadTrack;
using StaticAPI.Services;

namespace StaticAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TracksController : Controller
{
    private readonly IMediator _mediator;

    public TracksController(IFileProvider fp ,IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet("{id}")]
    public async Task<Task<IActionResult>> DownloadByIdAsync(string id)
    {
        var q = new Features.Track.GetById.Query(id);
        var res = await _mediator.Send(q);
        return (res.IsSuccessful)
            ? Task.FromResult<IActionResult>(new FileStreamResult(res.Value!, "application/octet-stream"))
            : Task.FromResult<IActionResult>(NotFound());
    }

    [HttpPost("upload")]
    public async Task<IActionResult> UploadFileAsync([FromForm] IFormFile? file)
    {
        var c = new Command(file);
        var res = await _mediator.Send(c);
        return res.IsSuccessful ? Ok() : BadRequest(res.JoinErrors());
    }
}