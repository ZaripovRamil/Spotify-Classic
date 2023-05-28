using Microsoft.AspNetCore.Mvc;
using StaticAPI.Services;

namespace StaticAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TracksController : Controller
{
    private readonly IFileProvider _fileProvider;

    public TracksController(IFileProvider fp)
    {
        _fileProvider = fp;
    }

    // TODO: change this to receive the whole path to the file, not just id
    [HttpGet("{id}")]
    public async Task<IActionResult> DownloadByIdAsync(string id)
    {
        var idSplit = id.Split('.');
        var fileName = Path.Combine(idSplit[0], idSplit.Length > 1 ? id : $"{id}.index.m3u8");
        var track = _fileProvider.GetFileAsStream("Tracks", fileName);
        if (track is null) return NotFound();
        return new FileStreamResult(track, "application/octet-stream");
    }

    [HttpPost("upload")]
    public async Task<IActionResult> UploadFileAsync([FromForm] IFormFile? file)
    {
        if (file is null || file.Length == 0)
            return BadRequest("Empty file");
        if (file.FileName.Length == 0)
            return BadRequest("Filename is not provided");
        await _fileProvider.UploadAsync("Tracks", file.FileName, file.OpenReadStream());
        return Ok();
    }
}