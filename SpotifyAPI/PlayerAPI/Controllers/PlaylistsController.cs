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
public class PlaylistsController : Controller
{
    private readonly HttpClient _clientToDb;

    public PlaylistsController(IOptions<ApplicationHosts> hostsOptions)
    {
        _clientToDb = new HttpClient
            { BaseAddress = new Uri($"https://localhost:{hostsOptions.Value.DatabaseAPI}/playlist/") };
    }
    [HttpGet("get/{id}")]
    public async Task<IActionResult> GetByIdAsync(string id)
    {
        var playlist = await _clientToDb.GetFromJsonAsync<PlaylistLight>($"get/id/{id}");
        if (playlist is null) return NotFound();
        return new JsonResult(playlist);
    }

    [HttpGet("get")]
    public async Task<IActionResult> GetAllAsync()
    {
        var playlists = await _clientToDb.GetFromJsonAsync<IEnumerable<PlaylistLight>>("get");
        return new JsonResult(playlists);
    }
}