using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.Light;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.FrontToBack.EntityUpdateData;

namespace AdminAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AlbumsController
{
    private readonly HttpClient _client;

    public AlbumsController(IConfiguration configuration)
    {
        var ports = configuration.GetSection("APIsPorts");
        _client = new HttpClient { BaseAddress = new Uri($"https://localhost:{ports.GetSection("Database").Value}") };
    }
    
    [HttpGet("get")]
    public async Task<IActionResult> GetAllAsync()
    {
        Console.WriteLine(_client.BaseAddress);
        var albums = await _client.GetFromJsonAsync<IEnumerable<AlbumLight>>("get");
        return new JsonResult(albums);
    }

    [HttpGet("get/{id}")]
    public async Task<IActionResult> GetByIdAsync(string id)
    {
        var album = await _client.GetFromJsonAsync<AlbumLight>($"get/id/{id}");
        return new JsonResult(album);
    }

    [HttpPost("add")]
    public async Task<IActionResult> Add([FromBody] AlbumCreationData creationData)
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
    public async Task<IActionResult> UpdateAsync(string id, [FromBody] AlbumUpdateData albumUpdateData)
    {
        var json = JsonSerializer.Serialize(albumUpdateData);
        var response =
            await _client.PutAsync($"update/{id}", new StringContent(json, Encoding.UTF8, "application/json"));
        var responseContent = await response.Content.ReadAsStringAsync();
        return new JsonResult(responseContent);
    }
}