using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.FrontToBack.Chat;
using MediatR;

namespace ChatApi.Controllers;

[ApiController]
[Route("chat")]
[Authorize]
public class ChatController : Controller
{
    private readonly IMediator _mediator;

    public ChatController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> History()
    {
        var username = User.Identity!.Name!;
        var q = new Features.UserChatHistory.Query(username);
        var res = await _mediator.Send(q);
        return res.IsSuccessful ? Ok(res.Value?.Messages) : BadRequest(res.Errors);
    }

    [Authorize(Roles = "Admin")]
    [HttpGet("[action]/{groupname}")]
    public async Task<IActionResult> History(string groupname)
    {
        var q = new Features.UserChatHistory.Query(groupname);
        var res = await _mediator.Send(q);
        return res.IsSuccessful ? Ok(res.Value?.Messages) : BadRequest(res.Errors);
    }
}