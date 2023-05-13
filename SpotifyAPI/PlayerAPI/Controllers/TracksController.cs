using DatabaseServices.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Models;
using Models.DTO.BackToFront.Full;
using Models.DTO.BackToFront.Light;

namespace PlayerAPI.Controllers;

// [Authorize(Roles = "Free,Premium,Admin")]
[ApiController]
[Route("[controller]")]
public class TracksController : Controller
{
    private readonly HttpClient _clientToDb;
    private readonly IDbUserRequester _userRequester;
    private readonly HttpClient _clientToStatic;

    public TracksController(IOptions<ApplicationHosts> hostsOptions, IDbUserRequester userRequester)
    {
        _userRequester = userRequester;
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

    [HttpGet("get/{trackId}")]
    public async Task<IActionResult> GetByIdAsStreamAsync(string trackId)
    {
        try
        {
            var responseStream = await _clientToStatic.GetStreamAsync(trackId);
            var username = HttpContext.User.Identity.Name;
            var userId = _userRequester.GetUserByUsername(username);
            //todo request databaseAPI

            return new FileStreamResult(responseStream, "application/octet-stream")
            {
                FileDownloadName = $"{trackId}.mp3",
                EnableRangeProcessing = true
            };
        }
        catch (HttpRequestException)
        {
            return NotFound();
        }
    }
}