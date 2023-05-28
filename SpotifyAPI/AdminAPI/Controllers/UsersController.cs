using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Models;
using Models.DTO.BackToFront.Full;
using Models.DTO.BackToFront.Light;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.FrontToBack.EntityUpdateData;

namespace AdminAPI.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize(Roles = "Admin")]
public class UsersController
{
    private readonly HttpClient _clientToDb;

    public UsersController(IOptions<ApplicationHosts> hostsOptions)
    {
        _clientToDb = new HttpClient
            { BaseAddress = new Uri($"https://localhost:{hostsOptions.Value.DatabaseAPI}/user/") };
    }
    
    [HttpGet("get")]
    public async Task<IActionResult> GetAllAsync()
    {
        var users = await _clientToDb.GetFromJsonAsync<IEnumerable<UserLight?>>("getAll");
        return new JsonResult(users);
    }
}