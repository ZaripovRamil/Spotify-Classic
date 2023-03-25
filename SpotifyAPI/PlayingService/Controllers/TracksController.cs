using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront;
using Models.DTO.BackToFront.Light;
using PlayingService.Services;

namespace PlayingService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TracksController : Controller
{
    private readonly IFileProvider _fileProvider;
    private readonly HttpClient _client = new();
    //TODO: move this to db
    private readonly TrackLight[] _tracks =
    {
        new()
        {
            Id = "1", Name = "Lacrimosa", PreviewId = "1",
            Album = new AlbumLight { Id = "1", Name = "Best of Mozart" },
            Author = new UserLight { Id = "1", Name = "Mozart" }
        },
        new()
        {
            Id = "2", Name = "you've been rickrolled", PreviewId = "2",
            Album = new AlbumLight { Id = "2", Name = "Best of today" },
            Author = new UserLight { Id = "2", Name = "Rick Astley" }
        },
        new()
        {
            Id = "3", Name = "Hungarian Rhapsody", PreviewId = "3",
            Album = new AlbumLight { Id = "3", Name = "Best of Liszt" },
            Author = new UserLight { Id = "3", Name = "Liszt" }
        }
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