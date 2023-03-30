using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using PlayingService.Services;

namespace PlayingService.Controllers;

[ApiController]
[Route("[controller]")]
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
         return new JsonResult(await _client.GetFromJsonAsync<IEnumerable<Track>>("http://localhost:5096/track/get"));
    }
}