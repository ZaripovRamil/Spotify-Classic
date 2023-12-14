using MediatR;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.FileDataDTO;
using StaticAPI.Features.Track.UploadTrack;

namespace StaticAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TracksController : Controller
{
    private readonly IMediator _mediator;

    public TracksController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> DownloadByIdAsync(string id)
    {
        var q = new Features.Track.GetById.Query(id);
        var res = await _mediator.Send(q);
        return res.IsSuccessful
            ? new FileStreamResult(res.Value!, "application/octet-stream")
            : NotFound();
    }

    [HttpPost("upload")]
    public async Task<IActionResult> UploadFileAsync([FromForm] TrackDataDto? trackData)
    {
        var c = new Command(trackData);
        var res = await _mediator.Send(c);
        return res.IsSuccessful ? Ok() : BadRequest(res.JoinErrors());
    }
}