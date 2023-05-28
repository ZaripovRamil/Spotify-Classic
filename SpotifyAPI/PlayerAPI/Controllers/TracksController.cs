using System.Text.Json;
using Microsoft.AspNetCore.Authorization;
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
    private static readonly JsonSerializerOptions Options = new() { PropertyNameCaseInsensitive = true };
    private readonly HttpClient _clientToDb;
    private readonly HttpClient _clientToStatic;
    private readonly HttpClient _clientToHistory;

    public TracksController(IOptions<ApplicationHosts> hostsOptions)
    {
        _clientToHistory = new HttpClient
            { BaseAddress = new Uri($"https://localhost:{hostsOptions.Value.DatabaseAPI}/history/") };
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
        if (trackId.Contains('.')) return await StreamTrack(trackId); // if file.ts requested, not track
        var trackInfo = await GetTrackInfo(trackId);

        return await StreamTrack(trackInfo.FileId);

    }

    private async Task<TrackFull> GetTrackInfo(string trackId)
    {
        var message = new HttpRequestMessage(HttpMethod.Get, $"get/id/{trackId}");
        var response = (await _clientToDb.SendAsync(message));
        var content = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<TrackFull>(content, Options);
    }

    private async Task<IActionResult> StreamTrack(string fileId)
    {
        try
        {
            var responseStream = await _clientToStatic.GetStreamAsync(fileId);
            return new FileStreamResult(responseStream, "application/octet-stream");
        }
        catch (HttpRequestException)
        {
            return NotFound();
        }
    }
    [HttpGet("addToHistory/{trackId}")]
    [Authorize]
    public async Task<IActionResult> AddTrackToHistory(string trackId)
    {
        try
        {
            var username = User.Identity.Name;
            var message = new HttpRequestMessage(HttpMethod.Post, $"Add?userName={username}&trackId={trackId}");
            await _clientToHistory.SendAsync(message);
            return Ok();
        }
        catch
        {
            return BadRequest();
        }
        
    }
}