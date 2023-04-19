using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.Light;

namespace AdminService.Controllers;

[ApiController]
[Route("[controller]")]
public class AlbumsController
{
    private readonly HttpClient _client = new();

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var tracks = await _client.GetFromJsonAsync<IEnumerable<AlbumLight>>("https://localhost:7093/album/get");
        return new JsonResult(tracks);
    }
}