using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.Light;
using Models.DTO.FrontToBack.EntityCreationData;

namespace AdminService.Controllers;

[ApiController]
[Route("[controller]")]
public class TracksController : Controller
{
    private readonly HttpClient _client = new(){BaseAddress = new Uri("https://localhost:7248/track/") };
    
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var tracks = await _client.GetFromJsonAsync<IEnumerable<TrackLight>>("get");
        return new JsonResult(tracks);
    }

    // doesn't work now. don't touch.
    [HttpPost]
    public async Task<IActionResult> AddAsync([FromBody] TrackCreationData creationData)
    {
        var resp = await _client.PostAsync("add", JsonContent.Create(creationData));
        var res = await resp.Content.ReadAsStringAsync();
        return res == "0" ? Ok() : NotFound();
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> DeleteAsync(string id)
    {
        var response = await _client.DeleteAsync($"delete/{id}");
        var responseContent = await response.Content.ReadAsStringAsync();
        return new JsonResult(responseContent);
    }
}