using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Models;
using Models.DTO.BackToFront.Full;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.FrontToBack.EntityUpdateData;
using Models.Entities;

namespace AdminAPI.Controllers;

[Authorize(Roles = "Admin")]
[ApiController]
[Route("[controller]")]
public class AuthorsController : Controller
{
    private readonly HttpClient _clientToDb;
    private readonly HttpClient _clientToSearch;

    public AuthorsController(IOptions<Hosts> hostsOptions)
    {
        _clientToSearch = new HttpClient
            { BaseAddress = new Uri($"http://{hostsOptions.Value.SearchApi}/search")};
        _clientToDb = new HttpClient
            { BaseAddress = new Uri($"http://{hostsOptions.Value.DatabaseApi}/author/") };
    }
    
    [HttpGet("get")]
    public async Task<IActionResult> GetAllAsync()
    {
        var authors = await _clientToDb.GetFromJsonAsync<IEnumerable<AuthorFull>>("get");
        return new JsonResult(authors);
    }

    [HttpGet("get/{id}")]
    public async Task<IActionResult> GetByIdAsync(string id)
    {
        var author = await _clientToDb.GetFromJsonAsync<AuthorFull>($"get/id/{id}");
        return new JsonResult(author);
    }

    [HttpPost("add")]
    public async Task<IActionResult> Add([FromBody] AuthorCreationData creationData)
    {
        var json = JsonSerializer.Serialize(creationData);
        var response = await _clientToDb.PostAsync("add", new StringContent(json, Encoding.UTF8, "application/json"));
        var responseContent = await response.Content.ReadAsStringAsync();
        return new JsonResult(responseContent);
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> DeleteAsync(string id)
    {
        var response = await _clientToDb.DeleteAsync($"delete/{id}");
        var responseContent = await response.Content.ReadAsStringAsync();
        return new JsonResult(responseContent);
    }

    [HttpPut("update/{id}")]
    public async Task<IActionResult> UpdateAsync(string id, AuthorUpdateData authorUpdateData)
    {
        var json = JsonSerializer.Serialize(authorUpdateData);
        var response =
            await _clientToDb.PutAsync($"update/{id}", new StringContent(json, Encoding.UTF8, "application/json"));
        var responseContent = await response.Content.ReadAsStringAsync();
        return new JsonResult(responseContent);
    }

    [HttpGet("search")]
    public async Task<IActionResult> FindAuthorByUserName([FromQuery] string? query)
    {
        var authors = await _clientToSearch.GetFromJsonAsync<IEnumerable<Author>>(
            $"authors/by/user?query={query}");
        return new JsonResult(authors?.Select(a => new AuthorFull(a)));
    }
}