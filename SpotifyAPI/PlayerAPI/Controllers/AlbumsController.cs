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
public class AlbumsController : Controller
{
    private readonly HttpClient _clientToDb;

    public AlbumsController(IOptions<ApplicationHosts> hostsOptions)
    {
        _clientToDb = new HttpClient
            { BaseAddress = new Uri($"https://localhost:{hostsOptions.Value.DatabaseAPI}/album/") };
    }
    
    [HttpGet("get")]
    public async Task<IActionResult> GetAllAsync()
    {
        var albums = await _clientToDb.GetFromJsonAsync<IEnumerable<AlbumFull>>("get");
        return new JsonResult(albums?.Select(album => new AlbumLight(album)));
    }
    
    [HttpGet("get/{id}")]
    public async Task<IActionResult> GetByIdAsync(string id)
    {
        var album = await _clientToDb.GetFromJsonAsync<AlbumFull>($"get/id/{id}");
        return new JsonResult(album is null ? null : new AlbumLight(album));
    }
}