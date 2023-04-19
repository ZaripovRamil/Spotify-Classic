using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.Light;

namespace AdminService.Controllers;

[ApiController]
[Route("[controller]")]
public class TracksController : Controller
{
    private readonly HttpClient _client = new();
    
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var tracks = await _client.GetFromJsonAsync<IEnumerable<TrackLight>>("https://localhost:7093/track/get");
        return new JsonResult(tracks);
    }
}