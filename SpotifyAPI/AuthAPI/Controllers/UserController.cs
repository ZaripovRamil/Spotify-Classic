using AuthAPI.Features.UpdatePassword;
using AuthAPI.Features.UpdateSubscription;
using MediatR;
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
    private readonly IMediator _mediator;

    public UserController(UserManager<User> userManager, IMediator mediator)
    {
        _userManager = userManager;
        _mediator = mediator;
    }

    [HttpGet]
    [Route("GetHistory")]
    public async Task<IActionResult> GetHistory()
    {
        var user = await GetContextUser();
        var query = new Features.GetUserHistory.Query(user);
        var res = await _mediator.Send(query);
        return res.IsSuccessful ? Ok(res.Value) : BadRequest(res.Errors);
    }

    [HttpGet]
    [Route("GetUserName")]
    public Task<IActionResult> GetUserName()
    {
        return Task.FromResult<IActionResult>(new JsonResult(User.Identity?.Name ?? string.Empty));
    }

    [HttpGet]
    [Route("GetMe")]
    public async Task<IActionResult> GetMe()
    {
        return await GetByUsername(User.Identity?.Name ?? string.Empty);
    }

    [HttpGet]
    [Route("Get/id/{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var user = await GetContextUser();
        var query = new Features.GetById.Query(id, user);
        var res = await _mediator.Send(query);
        return res.IsSuccessful
            ? res.Value!.UserDto.Match(
                x => new JsonResult(x),
                x => new JsonResult(x))
            : BadRequest(res.Errors);
    }

    [HttpGet]
    [Route("Get/username/{username}")]
    public async Task<IActionResult> GetByUsername(string username)
    {
        var user = await GetContextUser();
        var query = new Features.GetByUsername.Query(username, user);
        var res = await _mediator.Send(query);
        return res.IsSuccessful
            ? res.Value!.UserDto.Match(
                x => new JsonResult(x),
                x => new JsonResult(x))
            : BadRequest(res.Errors);
    }

    [HttpGet]
    [Route("get/statistics")]
    public async Task<IActionResult> GetStatistics()
    {
        var user = await GetContextUser();
        var query = new Features.GetStatistics.Query(user);
        var res = await _mediator.Send(query);
        return res.IsSuccessful ? Ok(res.Value) : BadRequest(res.Errors);
    }

    [HttpPut]
    [Route("subscription/update")]
    public async Task<IActionResult> UpdateSubscription([FromBody] SubscriptionUpdateData data)
    {
        var user = await GetContextUser();
        var command = new Features.UpdateSubscription.Command(data, user);
        var res = await _mediator.Send(command);
        return res.IsSuccessful ? Ok() : BadRequest();
    }


    [HttpPut]
    [Route("update/password")]
    public async Task<IActionResult> UpdatePassword([FromBody] PasswordUpdateData updateData)
    {
        var user = await GetContextUser();
        var command = new Features.UpdatePassword.Command(updateData, user);
        var res = await _mediator.Send(command);
        return res.IsSuccessful ? Ok() : BadRequest();
    }

    [HttpPut]
    [Route("update/username/{username}")]
    public async Task<IActionResult> UpdateUsername(string username)
    {
        var user = await GetContextUser();
        var command = new Features.UpdateUsername.Command(username, user);
        var res = await _mediator.Send(command);
        return res.IsSuccessful ? Ok() : BadRequest();
    }

    private async Task<User?> GetContextUser()
    {
        return await _userManager.Users
            .Include(u => u.Subscription)
            .Include(u => u.Playlists)
            .Include(u => u.Playlists)
            .ThenInclude(p => p.Tracks)
            .Include(u => u.History)
            .ThenInclude(t => t.Album)
            .ThenInclude(a => a.Author)
            .Include(u => u.History)
            .ThenInclude(t => t.Genres)
            .Include(u => u.Playlists)
            .FirstOrDefaultAsync(u => u.UserName == User.Identity!.Name);
    }
}