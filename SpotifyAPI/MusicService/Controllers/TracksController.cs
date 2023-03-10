using Microsoft.AspNetCore.Mvc;
using MusicService.Services;

namespace MusicService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TracksController : Controller
{
    private readonly IFileProvider _fileProvider;
    private readonly HttpClient _client = new();

    private readonly Track[] _tracks =
    {
        new() { Url = "tracks/1", Name = "Lacrimosa" },
        new() { Url = "tracks/2", Name = "you've been rickrolled" },
        new() { Url = "tracks/3", Name = "Hungarian Rhapsody" }
    };

    public TracksController(IFileProvider fp)
    {
        _fileProvider = fp;
    }

    [HttpGet("{id}")]
    public IActionResult DownloadById(string id)
    {
        var track = _fileProvider.GetFileAsStream($"Assets/{id}.mp3");
        if (track is null) return NotFound();
        return File(track, "application/octet-stream", $"{id}.mp3");
    }

    [HttpGet]
    public JsonResult GetAll()
    {
        // TODO: uncomment this when db controller will be ready
        // return new JsonResult(await _client.GetFromJsonAsync<IEnumerable<Track>>("[url to db request here]"));
        return new JsonResult(_tracks);
    }
}

public class Track
{
    public string Url { get; set; }
    public string Name { get; set; }
}