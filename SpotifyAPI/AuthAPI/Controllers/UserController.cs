using DatabaseServices.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace AuthAPI.Controllers;

[ApiController]
[Authorize]
[Route("[controller]")]
public class UserController : Controller
{
    private readonly UserManager<User> _userManager;
    private readonly IDtoCreator _dtoCreator;

    public UserController(UserManager<User> userManager, IDtoCreator dtoCreator)
    {
        _userManager = userManager;
        _dtoCreator = dtoCreator;
    }

    [HttpGet]
    [Route("Get/id/{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var user = await GetContextUser(HttpContext.Request.Headers["Authorization"]);
        return new JsonResult(user.Id == id
            ? _dtoCreator.CreateFull(user)
            : _dtoCreator.CreateLight(_userManager.Users.FirstOrDefault(u => u.Id == id)));
    }

    [HttpGet]
    [Route("Get/username/{username}")]
    public async Task<IActionResult> GetByUsername(string username)
    {
        var user = await GetContextUser(HttpContext.Request.Headers["Authorization"]);
        return new JsonResult(user.UserName == username
            ? _dtoCreator.CreateFull(user)
            : _dtoCreator.CreateLight(_userManager.Users.FirstOrDefault(u => u.UserName == username)));
    }

    [HttpPut]
    [Route("update/password")]
    public async Task<IActionResult> UpdatePassword([FromQuery] string oldPassword, [FromQuery] string newPassword)
    {
        var user = await GetContextUser(HttpContext.Request.Headers["Authorization"]);
        var result = await _userManager.ChangePasswordAsync(user, oldPassword, newPassword);
        if (result.Succeeded) return Ok();
        return BadRequest();
    }

    [HttpPut]
    [Route("update/username/{username}")]
    public async Task<IActionResult> UpdateUsername(string username)
    {
        if (!ValidateUsername(username))
            return BadRequest();
        var user = await GetContextUser(HttpContext.Request.Headers["Authorization"]);

        user.UserName = username;
        var result = await _userManager.UpdateAsync(user);
        if (result.Succeeded) return Ok();
        return BadRequest();
    }

    private static bool ValidateUsername(string username)
    {
        return username.All(char.IsLetterOrDigit) && username.Length >= 4;
    }

    private async Task<User?> GetContextUser(string jwt)
    {
        return await _userManager.Users
            .Include(u => u.History)
            .ThenInclude(t => t.Album)
            .ThenInclude(a => a.Author)
            .Include(u => u.Playlists)
            .FirstOrDefaultAsync(u => u.Id == User.Identity.Name);
    }
}