using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront;
using PlayingService.Services;

namespace PlayingService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TracksController : Controller
{
    private readonly IFileProvider _fileProvider;
    private readonly HttpClient _client = new();

    private readonly TrackLight[] _tracks =
    {
        new()
        {
            Id = "1", Name = "Lacrimosa", PreviewId = "1",
            Album = new AlbumLight { Id = "1", Name = "Best of Mozart" },
            Author = new AuthorLight { Id = "1", Name = "Mozart" }
        },
        new()
        {
            Id = "2", Name = "you've been rickrolled", PreviewId = "2",
            Album = new AlbumLight { Id = "2", Name = "Best of today" },
            Author = new AuthorLight { Id = "2", Name = "Rick Astley" }
        },
        new()
        {
            Id = "3", Name = "Hungarian Rhapsody", PreviewId = "3",
            Album = new AlbumLight { Id = "3", Name = "Best of Liszt" },
            Author = new AuthorLight { Id = "3", Name = "Liszt" }
        }
    };

    public TracksController(IFileProvider fp)
    {
        _fileProvider = fp;
    }

    [HttpGet("{id}")]
    public async Task<FileStreamResult> DownloadByIdAsync (string id)
    {
        var track = _fileProvider.GetFileAsStream($"Assets/Tracks/{id}.mp3");
        
        return new FileStreamResult(track, "application/octet-stream")
        {
            FileDownloadName = $"{id}.mp3",
            EnableRangeProcessing = true
        };
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        // TODO: uncomment this when db controller will be ready
        // return new JsonResult(await _client.GetFromJsonAsync<IEnumerable<Track>>("https://localhost:7093/track/get"));
        return new JsonResult(_tracks);
    }
}