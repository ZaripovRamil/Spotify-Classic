using Microsoft.AspNetCore.Mvc;

namespace PlayerAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PreviewsController : Controller
{
    private readonly HttpClient _clientToStatic = new() { BaseAddress = new Uri("https://localhost:7153/previews/") };
    
    [HttpGet("get/{id}")]
    public async Task<IActionResult> GetByIdAsync(string id)
    {
        var response = await _clientToStatic.GetAsync(id);
        if (!response.IsSuccessStatusCode) return NotFound();
        return File(await response.Content.ReadAsStreamAsync(), "application/octet-stream");
    }
}