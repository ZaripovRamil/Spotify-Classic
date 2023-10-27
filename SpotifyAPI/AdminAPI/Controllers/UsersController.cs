using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Models.Configuration;
using Models.DTO.BackToFront.Light;

namespace AdminAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController
{
    private readonly HttpClient _clientToDb;

    public UsersController(IOptions<Hosts> hostsOptions)
    {
        _clientToDb = new HttpClient
            { BaseAddress = new Uri($"http://{hostsOptions.Value.DatabaseApi}/") };
    }

    [Authorize(Roles = "Admin")]
    [HttpGet("get")]
    public async Task<IActionResult> GetAllRoomsAsync()
    {
        var users = await _clientToDb.GetFromJsonAsync<IEnumerable<string>>("chatUsers/getAllRooms");
        return new JsonResult(users);
    }
    
    [HttpGet("getUsers")]
    public async Task<IActionResult> GetAllAsync()
    {
        var users = await _clientToDb.GetFromJsonAsync<IEnumerable<UserLight?>>("user/getAll");
        return new JsonResult(users);
    }
    
    // add user promotion controller when refactoring db 
}
