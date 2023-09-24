using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Models;
using Models.DTO.BackToFront.Light;

namespace AdminAPI.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize(Roles = "Admin")]
public class UsersController
{
    private readonly HttpClient _clientToDb;

    public UsersController(IOptions<Hosts> hostsOptions)
    {
        _clientToDb = new HttpClient
            { BaseAddress = new Uri($"http://{hostsOptions.Value.DatabaseApi}/user/") };
    }

    [HttpGet("get")]
    public async Task<IActionResult> GetAllAsync()
    {
        var users = await _clientToDb.GetFromJsonAsync<IEnumerable<UserLight?>>("getAll");
        return new JsonResult(users);
    }
}