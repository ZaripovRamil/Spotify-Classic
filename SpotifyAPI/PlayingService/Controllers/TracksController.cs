using Microsoft.AspNetCore.Mvc;
using PlayingService.Services;

namespace PlayingService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TracksController : Controller
{
    private readonly IFileProvider _fileProvider;
    private readonly HttpClient _client = new();

    private readonly Track[] _tracks =
    {
        new() { Id = 1, Name = "Lacrimosa", PreviewId = 1},
        new() { Id = 2, Name = "you've been rickrolled", PreviewId = 2},
        new() { Id = 3, Name = "Hungarian Rhapsody", PreviewId = 3}
    };

    public TracksController(IFileProvider fp)
    {
        _fileProvider = fp;
    }

    [HttpGet("{id}")]
    public IActionResult DownloadById(string id)
    {
        var track = _fileProvider.GetFileAsStream($"Assets/Tracks/{id}.mp3");
        Response.ContentLength = _fileProvider.GetFileLength($"Assets/Tracks/{id}.mp3");
        // TODO: implement the below logic (server can send byte ranges)
        Response.Headers.AcceptRanges = "bytes"; // server can't (now)actually do it. here just for the reason.
        if (track is null) return NotFound();
        return File(track, "application/octet-stream", $"{id}.mp3");
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        // TODO: uncomment this when db controller will be ready
        // return new JsonResult(await _client.GetFromJsonAsync<IEnumerable<Track>>("https://localhost:7093/track/get"));
        return new JsonResult(_tracks);
    }
}

public class Track
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int PreviewId { get; set; }
}