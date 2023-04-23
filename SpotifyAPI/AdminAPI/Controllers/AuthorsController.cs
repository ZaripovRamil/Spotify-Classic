using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.Light;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.FrontToBack.EntityUpdateData;

namespace AdminService.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorsController : Controller
{
    private readonly HttpClient _client = new() { BaseAddress = new Uri("https://localhost:7248/author/") };
    
    [HttpGet("get")]
    public async Task<IActionResult> GetAllAsync()
    {
        var tracks = await _client.GetFromJsonAsync<IEnumerable<AuthorLight>>("get");
        return new JsonResult(tracks);
    }

    [HttpPost("add")]
    public async Task<IActionResult> Add([FromBody] AuthorCreationData creationData)
    {
        var json = JsonSerializer.Serialize(creationData);
        var response = await _client.PostAsync("add", new StringContent(json, Encoding.UTF8, "application/json"));
        var responseContent = await response.Content.ReadAsStringAsync();
        return new JsonResult(responseContent);
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> DeleteAsync(string id)
    {
        var response = await _client.DeleteAsync($"delete/{id}");
        var responseContent = await response.Content.ReadAsStringAsync();
        return new JsonResult(responseContent);
    }

    [HttpPut("update/{id}")]
    public async Task<IActionResult> UpdateAsync(string id, AuthorUpdateData authorUpdateData)
    {
        var json = JsonSerializer.Serialize(authorUpdateData);
        var response =
            await _client.PutAsync($"update/{id}", new StringContent(json, Encoding.UTF8, "application/json"));
        var responseContent = await response.Content.ReadAsStringAsync();
        return new JsonResult(responseContent);
    }
}