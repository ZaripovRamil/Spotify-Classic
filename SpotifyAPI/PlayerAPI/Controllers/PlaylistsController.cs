using System.Net;
using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Models;
using Models.DTO;
using Models.DTO.BackToFront.Full;
using Models.DTO.BackToFront.Light;
using Models.DTO.FrontToBack;

namespace PlayerAPI.Controllers;

[Authorize(Roles = "Free,Premium,Admin")]
[ApiController]
[Route("[controller]")]
public class PlaylistsController : Controller
{
    private readonly HttpClient _clientToDb;

    public PlaylistsController(IOptions<Hosts> hostsOptions)
    {
        _clientToDb = new HttpClient
            { BaseAddress = new Uri($"http://{hostsOptions.Value.DatabaseApi}/playlist/") };
    }

    [HttpGet("get/{id}")]
    public async Task<IActionResult> GetByIdAsync(string id)
    {
        var playlist = await _clientToDb.GetFromJsonAsync<PlaylistFull>($"get/id/{id}");
        if (playlist is null) return NotFound();
        return new JsonResult(playlist);
    }

    [HttpGet("get")]
    public async Task<IActionResult> GetAllAsync()
    {
        var playlists = await _clientToDb.GetFromJsonAsync<IEnumerable<PlaylistFull>>("get");
        return new JsonResult(playlists?.Select(playlist => new PlaylistLight(playlist)));
    }

    [HttpPost("addtrack")]
    public async Task<IActionResult> AddTrack([FromBody] PlaylistTrackOperationData data)
    {
        var json = JsonSerializer.Serialize(new PlaylistTrackOperationDataWithUser(data, User.Identity.Name));
        var resp = await _clientToDb.PostAsync("AddTrack", new StringContent(json, Encoding.UTF8, "application/json"));
        if (resp.IsSuccessStatusCode)
            return Ok();
        if (resp.StatusCode == HttpStatusCode.Forbidden)
            return Forbid();
        return BadRequest();
    }

    [HttpPost("DeleteTrack")]
    public async Task<IActionResult> DeleteTrack([FromBody] PlaylistTrackOperationData data)
    {
        var json = JsonSerializer.Serialize(new PlaylistTrackOperationDataWithUser(data, User.Identity.Name));
        var resp = await _clientToDb.PostAsync("DeleteTrack",
            new StringContent(json, Encoding.UTF8, "application/json"));
        if (resp.IsSuccessStatusCode)
            return Ok();
        if (resp.StatusCode == HttpStatusCode.Forbidden)
            return Forbid();
        return BadRequest();
    }
}