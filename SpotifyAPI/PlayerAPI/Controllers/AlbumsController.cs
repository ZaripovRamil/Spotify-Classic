using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.Full;
using Models.DTO.BackToFront.Light;

namespace PlayerAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AlbumsController : Controller
{
    private readonly HttpClient _client = new() { BaseAddress = new Uri("https://localhost:7248/album/") };
    
    [HttpGet("get")]
    public async Task<IActionResult> GetAllAsync()
    {
        var albums = await _client.GetFromJsonAsync<IEnumerable<AlbumFull>>("get");
        return new JsonResult(albums?.Select(album => new AlbumLight(album)));
    }

    [HttpGet("get/{id}")]
    public async Task<IActionResult> GetByIdAsync(string id)
    {
        var album = await _client.GetFromJsonAsync<AlbumFull>($"get/id/{id}");
        return new JsonResult(album is null ? null : new AlbumLight(album));
    }
}