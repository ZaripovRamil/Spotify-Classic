using Amazon.S3;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using StaticAPI.Features.Track.UploadTrack;

namespace StaticAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TracksController : Controller
{
    private readonly IMediator _mediator;
    private readonly IAmazonS3 _s3Client;

    public TracksController(IMediator mediator, IAmazonS3 s3Client)
    {
        _mediator = mediator;
        _s3Client = s3Client;
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
    public async Task<IActionResult> UploadFileAsync([FromForm] IFormFile? file)
    {
        var c = new Command(file);
        var res = await _mediator.Send(c);
        return res.IsSuccessful ? Ok() : BadRequest(res.JoinErrors());
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var lst = await _s3Client.ListObjectsAsync(Constants.S3Storage.TracksBucketName);
        return Ok(lst.S3Objects.Select(x => x.Key));
    }
    
    [HttpGet("pending")]
    public async Task<IActionResult> GetPendingAsync()
    {
        var lst = await _s3Client.ListObjectsAsync(Constants.S3Storage.TracksPendingBucketName);
        return Ok(lst.S3Objects.Select(x => x.Key));
    }
}