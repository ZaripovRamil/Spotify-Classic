using Microsoft.AspNetCore.Mvc;
using MusicService.Services;

namespace MusicService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TracksController : Controller
{
    private readonly IFileProvider _fileProvider;

    public TracksController(IFileProvider fp)
    {
        _fileProvider = fp;
    }

    [HttpGet("{id}")]
    public IActionResult GetById(string id)
    {
        var track = _fileProvider.GetFileAsStream($"{id}.mp3");
        if (track is null) return NotFound();
        return File(track, "application/octet-stream", $"{id}.mp3");
    }
}