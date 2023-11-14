using AuthAPI.Features.SignIn.Standard;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthAPI.Controllers;

[AllowAnonymous]
[ApiController]
[Route("[controller]/[action]")]
public class AuthController : Controller
{
    private readonly IMediator _mediator;

    public AuthController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginData loginData)
    {
        var command = new Features.SignIn.Standard.Command(loginData);
        var res = await _mediator.Send(command);
        return res.IsSuccessful ? Ok(res.Value) : BadRequest();
    }
}