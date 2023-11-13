using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdminAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController
{
    private readonly IMediator _mediator;

    public UsersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [Authorize(Roles = "Admin")]
    [HttpGet("rooms")]
    public async Task<IActionResult> GetAllRooms()
    {
        var query = new Features.Users.GetAllRooms.Query();
        var res = await _mediator.Send(query);
        return new JsonResult(res.Value);
    }

    [Authorize(Roles = "Admin")]
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var query = new Features.Users.GetAll.Query();
        var res = await _mediator.Send(query);
        return new JsonResult(res.Value);
    }

    [HttpPost]
    [Route("promote")]
    public async Task<IActionResult> MakeAdminAsync([FromBody] string login)
    {
        var command = new Features.Users.MakeAdmin.Command(login);
        var res = await _mediator.Send(command);
        return res.IsSuccessful switch
        {
            false => new NotFoundResult(),
            true when res.Value!.IsSuccessful => new OkResult(),
            _ => new NotFoundResult()
        };
    }
}