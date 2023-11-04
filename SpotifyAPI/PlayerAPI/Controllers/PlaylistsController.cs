using DatabaseServices.Services.Repositories.Implementations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.DTO;
using Models.DTO.BackToFront.Light;
using Models.DTO.FrontToBack;

namespace PlayerAPI.Controllers;

[Authorize(Roles = "Free,Premium,Admin")]
[ApiController]
[Route("[controller]")]
public class PlaylistsController : Controller
{
    private readonly IPlaylistRepository _playlistRepository;
    private readonly ITrackRepository _trackRepository;

    public PlaylistsController(IPlaylistRepository playlistRepository, ITrackRepository trackRepository)
    {
        _playlistRepository = playlistRepository;
        _trackRepository = trackRepository;
    }

    [HttpGet("get/{id}")]
    public async Task<IActionResult> GetByIdAsync(string id)
    {
        var playlist = await _playlistRepository.GetByIdAsync(id);
        if (playlist is null) return NotFound();
        return new JsonResult(playlist);
    }

    [HttpGet("get")]
    public IActionResult GetAll()
    {
        var playlists = _playlistRepository.GetAll();
        return new JsonResult(playlists.Select(playlist => new PlaylistLight(playlist)));
    }

    [HttpPost("addtrack")]
    public async Task<IActionResult> AddTrackAsync([FromBody] PlaylistTrackOperationData data)
    {
        var dto = new PlaylistTrackOperationDataWithUser(data, User.Identity?.Name!);
        var playlist = await _playlistRepository.GetByIdAsync(dto.PlaylistId);
        var track = await _trackRepository.GetByIdAsync(dto.TrackId);
        if (playlist == null || track == null)
            return BadRequest();
        if (playlist.Owner.UserName != dto.UserName)
            return Forbid();
        await _playlistRepository.AddTrackAsync(playlist, track);
        return Ok();
    }

    [HttpPost("DeleteTrack")]
    public async Task<IActionResult> DeleteTrack([FromBody] PlaylistTrackOperationData data)
    {
        var dto = new PlaylistTrackOperationDataWithUser(data, User.Identity?.Name!);
        var playlist = await _playlistRepository.GetByIdAsync(data.PlaylistId);
        var track = await _trackRepository.GetByIdAsync(data.TrackId);
        if (playlist == null || track == null)
            return BadRequest();
        if (playlist.Owner.UserName != dto.UserName)
            return Forbid();
        await _playlistRepository.DeleteTrackAsync(playlist, track);
        return Ok();
    }
}