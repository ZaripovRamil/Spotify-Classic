using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Models.Configuration;

namespace PlayerAPI.Controllers;

// [Authorize(Roles = "Free,Premium,Admin")]
[ApiController]
[Route("[controller]")]
public class PreviewsController : Controller
{
    private readonly HttpClient _clientToStatic;

    public PreviewsController(IOptions<Hosts> hostsOptions)
    {
        _clientToStatic = new HttpClient
            { BaseAddress = new Uri($"http://{hostsOptions.Value.StaticApi}/previews/") };
    }

    [HttpGet("get/{id:guid}")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        var response = await _clientToStatic.GetAsync(id.ToString());
        if (!response.IsSuccessStatusCode) return NotFound();
        return File(await response.Content.ReadAsStreamAsync(), "application/octet-stream");
    }
}