using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.FrontToBack.Auth;

namespace AuthAPI.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class RegistrationController : Controller
{
    private readonly IMediator _mediator;

    public RegistrationController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Add([FromBody] RegistrationData rData)
    {
        var command = new Features.SignUp.Standard.Command(rData);
        var res = await _mediator.Send(command);
        return res.IsSuccessful ? Ok(res.Value) : BadRequest(res.Value);
    }
}