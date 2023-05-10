using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Models;

namespace PlayerAPI.Controllers;

[Authorize(Roles = "Free,Premium,Admin")]
[ApiController]
[Route("[controller]")]
public class PreviewsController : Controller
{
    private readonly HttpClient _clientToStatic;

    public PreviewsController(IOptions<ApplicationHosts> hostsOptions)
    {
        _clientToStatic = new HttpClient
            { BaseAddress = new Uri($"https://localhost:{hostsOptions.Value.StaticAPI}/previews/") };
    }
    
    [HttpGet("get/{id}")]
    public async Task<IActionResult> GetByIdAsync(string id)
    {
        var response = await _clientToStatic.GetAsync(id);
        if (!response.IsSuccessStatusCode) return NotFound();
        return File(await response.Content.ReadAsStreamAsync(), "application/octet-stream");
    }
}