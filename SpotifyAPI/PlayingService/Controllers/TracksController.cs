using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using PlayingService.Services;

namespace PlayingService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TracksController : Controller
{
    private readonly IFileProvider _fileProvider;
    private readonly HttpClient _client = new();
    //TODO: move this to db

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
         return new JsonResult(await _client.GetFromJsonAsync<IEnumerable<Track>>("http://localhost:5096/track/get"));
    }
}