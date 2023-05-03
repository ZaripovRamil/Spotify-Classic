using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.Full;
using Models.DTO.BackToFront.Light;

namespace PlayerAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TracksController : Controller
{
    private readonly HttpClient _clientToDb = new() { BaseAddress = new Uri("https://localhost:7248/track/") };
    private readonly HttpClient _clientToStatic = new() { BaseAddress = new Uri("https://localhost:7153/tracks/") };
    
    [HttpGet("get")]
    public async Task<IActionResult> GetAllAsync()
    {
        var tracks = await _clientToDb.GetFromJsonAsync<IEnumerable<TrackFull>>("get");
        return new JsonResult(tracks?.Select(trackFull => new TrackLight(trackFull)));
    }

    [HttpGet("get/{id}")]
    public async Task<IActionResult> GetByIdAsStreamAsync(string id)
    {
        try
        {
            var responseStream = await _clientToStatic.GetStreamAsync(id);
            return new FileStreamResult(responseStream, "application/octet-stream")
            {
                FileDownloadName = $"{id}.mp3",
                EnableRangeProcessing = true
            };
        }
        catch (HttpRequestException)
        {
            return NotFound();
        }
    }
}