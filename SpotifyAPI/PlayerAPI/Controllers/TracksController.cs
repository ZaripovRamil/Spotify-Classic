using System.Text.RegularExpressions;
using DatabaseServices.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Models.Configuration;
using Models.DTO.BackToFront.Full;
using Models.DTO.BackToFront.Light;

namespace PlayerAPI.Controllers;

// [Authorize(Roles = "Free,Premium,Admin")]
[ApiController]
[Route("[controller]")]
public partial class TracksController : Controller
{
    private readonly ITrackRepository _trackRepository;
    private readonly IUserRepository _userRepository;
    private readonly HttpClient _clientToStatic;

    public TracksController(IOptions<Hosts> hostsOptions, ITrackRepository trackRepository,
        IUserRepository userRepository)
    {
        _trackRepository = trackRepository;
        _userRepository = userRepository;

        _clientToStatic = new HttpClient
            { BaseAddress = new Uri($"http://{hostsOptions.Value.StaticApi}/tracks/") };
    }

    [HttpGet("get")]
    public IActionResult GetAll()
    {
        var tracks = _trackRepository.GetAll();
        return new JsonResult(tracks.Select(trackFull => new TrackLight(trackFull)));
    }

    [HttpGet("get/{id}")]
    public async Task<IActionResult> GetByIdAsStreamAsync(string id)
    {
        if (!TrackIdRegex().IsMatch(id)) return BadRequest();
        if (id.EndsWith(".ts")) // if file.ts requested, not track
            return await StreamTrack(id);
        var trackInfo = await GetTrackInfo(id);
        if (trackInfo is null)
            return BadRequest();

        return await StreamTrack(trackInfo.FileId);
    }

    private async Task<TrackFull?> GetTrackInfo(string trackId)
    {
        var track = await _trackRepository.GetByIdAsync(trackId);
        return track is null ? null : new TrackFull(track);
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
    public async Task<IActionResult> AddTrackToHistory(string trackId)
    {
        var userName = User.Identity?.Name!;
        var user = await _userRepository.GetByNameAsync(userName);
        var track = await _trackRepository.GetByIdAsync(trackId);
        if (user == null || track == null)
            return BadRequest("Invalid ids");
        await _userRepository.AddTrackToHistoryAsync(user, track);
        return Ok();
    }

    [GeneratedRegex("^[a-zA-Z0-9_.-]+$", default, 500)]
    private static partial Regex TrackIdRegex();
}