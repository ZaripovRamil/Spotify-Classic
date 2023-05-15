using DatabaseServices.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.DTO.BackToFront.Light;
using Models.DTO.FrontToBack.EntityUpdateData;
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
    [Route("GetHistory")]
    public async Task<IActionResult> GetHistory()
    {
        var user = await GetContextUser();
        return new JsonResult(user.Playlists.Select(p => new PlaylistLight(p)).ToList());
    }

    [HttpGet]
    [Route("GetUserName")]
    public async Task<IActionResult> GetUserName()
    {
        var user = await GetContextUser();
        return new JsonResult(user.Name);
    }

    [HttpGet]
    [Route("GetMe")]
    public async Task<IActionResult> GetMe()
    {
        var user = await GetContextUser();
        return new JsonResult(_dtoCreator.CreateFull(user));
    }

    [HttpGet]
    [Route("Get/id/{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var user = await GetContextUser();
        return new JsonResult(user.Id == id
            ? _dtoCreator.CreateFull(user)
            : _dtoCreator.CreateLight(_userManager.Users.FirstOrDefault(u => u.Id == id)));
    }

    [HttpGet]
    [Route("Get/username/{username}")]
    public async Task<IActionResult> GetByUsername(string username)
    {
        var user = await GetContextUser();
        return new JsonResult(user.UserName == username
            ? _dtoCreator.CreateFull(user)
            : _dtoCreator.CreateLight(_userManager.Users.FirstOrDefault(u => u.UserName == username)));
    }


    [HttpPut]
    [Route("update/password")]
    public async Task<IActionResult> UpdatePassword([FromBody] PasswordUpdateData updateData)
    {
        if (updateData.Password != updateData.RepeatPassword) return BadRequest();
        var user = await GetContextUser();
        var result = await _userManager.ChangePasswordAsync(user, updateData.OldPassword, updateData.Password);
        if (result.Succeeded) return Ok();
        return BadRequest();
    }

    [HttpPut]
    [Route("update/username/{username}")]
    public async Task<IActionResult> UpdateUsername(string username)
    {
        if (!ValidateUsername(username))
            return BadRequest();
        var user = await GetContextUser();

        user.Name = username;
        var result = await _userManager.UpdateAsync(user);
        if (result.Succeeded) return Ok();
        return BadRequest();
    }

    private static bool ValidateUsername(string username)
    {
        return username.All(char.IsLetterOrDigit) && username.Length >= 4;
    }

    private async Task<User?> GetContextUser()
    {
        return await _userManager.Users
            .Include(u => u.Playlists)
            .Include(u => u.Playlists)
            .ThenInclude(p => p.Tracks)
            .Include(u => u.History)
            .ThenInclude(t => t.Album)
            .ThenInclude(a => a.Author)
            .Include(u => u.Playlists)
            .FirstOrDefaultAsync(u => u.UserName == User.Identity.Name);
    }
}