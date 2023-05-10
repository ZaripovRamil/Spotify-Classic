using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Models;
using Models.DTO.BackToFront.Full;
using Models.DTO.BackToFront.Light;

namespace PlayerAPI.Controllers;

[Authorize(Roles = "Free,Premium,Admin")]
[ApiController]
[Route("[controller]")]
public class TracksController : Controller
{
    private readonly HttpClient _clientToDb;
    private readonly HttpClient _clientToStatic;

    public TracksController(IOptions<ApplicationHosts> hostsOptions)
    {
        _clientToDb = new HttpClient
            { BaseAddress = new Uri($"https://localhost:{hostsOptions.Value.DatabaseAPI}/track/") };
        _clientToStatic = new HttpClient
            { BaseAddress = new Uri($"https://localhost:{hostsOptions.Value.StaticAPI}/tracks/") };
    }
    
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