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

    [HttpGet("{id}")]
    public async Task<IActionResult> DownloadByIdAsync(string id)
    {
        var track = _fileProvider.GetFileAsStream($"Assets/Tracks/{id}.mp3");
        if (track is null) return NotFound();
        return new FileStreamResult(track, "application/octet-stream")
        {
            FileDownloadName = $"{id}.mp3",
            EnableRangeProcessing = true
        };
    }
}