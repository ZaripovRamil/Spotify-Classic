using Microsoft.AspNetCore.Mvc;
using Models;

namespace PlayerAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PreviewsController : Controller
{
    private readonly HttpClient _clientToStatic;

    public PreviewsController(ApplicationHosts hosts)
    {
        _clientToStatic = new HttpClient { BaseAddress = new Uri($"https://localhost:{hosts.StaticAPI}/previews/") };
    }
    
    [HttpGet("get/{id}")]
    public async Task<IActionResult> GetByIdAsync(string id)
    {
        var response = await _clientToStatic.GetAsync(id);
        if (!response.IsSuccessStatusCode) return NotFound();
        return File(await response.Content.ReadAsStreamAsync(), "application/octet-stream");
    }
}