using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.BackToFront.Light;
using Models.DTO.FrontToBack.EntityCreationData;

namespace AdminService.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorsController : Controller
{
    private readonly HttpClient _client = new() {BaseAddress = new Uri("https://localhost:7093/author/")};
    
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var tracks = await _client.GetFromJsonAsync<IEnumerable<AuthorLight>>("get");
        return new JsonResult(tracks);
    }

    [HttpPost]
    public async Task<AuthorCreationCode> AddAsync([FromBody] AuthorCreationData creationData) =>
        await _client.GetFromJsonAsync<AuthorCreationCode>("add");
}