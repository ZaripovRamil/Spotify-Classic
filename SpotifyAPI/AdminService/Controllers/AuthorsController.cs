using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.Light;

namespace AdminService.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorsController : Controller
{
    private readonly HttpClient _client = new();
    
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var tracks = await _client.GetFromJsonAsync<IEnumerable<AuthorLight>>("https://localhost:7093/author/get");
        return new JsonResult(tracks);
    }
}