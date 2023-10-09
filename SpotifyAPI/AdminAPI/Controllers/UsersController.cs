using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Models.Configuration;

namespace AdminAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController
{
    private readonly HttpClient _clientToDb;

    public UsersController(IOptions<Hosts> hostsOptions)
    {
        _clientToDb = new HttpClient
            { BaseAddress = new Uri($"http://{hostsOptions.Value.DatabaseApi}/chatUsers/") };
    }

    [Authorize(Roles = "Admin")]
    [HttpGet("get")]
    public async Task<IActionResult> GetAllAsync()
    {
        var users = await _clientToDb.GetFromJsonAsync<IEnumerable<string>>("getAllRooms");
        return new JsonResult(users);
    }
    
    // shitcode yeah
    [HttpPost("promote")]
    public async Task<IActionResult> PromoteAsync([FromBody] PromoteToAdminDto dto)
    {
        var isDevelopment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development";
        if (!isDevelopment) return new NotFoundResult();
        var data = $"{{\"login\":\"{dto.username}\"}}";
        var content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
        
        try
        {
            var res = await _clientToDb.PostAsync("promote", content);
            if (!res.IsSuccessStatusCode) return new NotFoundResult();
        }
        catch
        {
            return new NotFoundResult();
        }

        return new OkResult();
    }
    
    public record PromoteToAdminDto(string username);
}
