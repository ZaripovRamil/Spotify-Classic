using AuthService.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.Auth;
using Models.DTO.FrontToBack.Auth;
using Models.Entities;

namespace AuthService.Controllers;

[ApiController]
[Route("Auth")]
public class AuthController
{
    private readonly SignInManager<User> _signInManager;
    private IDbRequester Requester { get; }

    public AuthController(SignInManager<User> signInManager, IDbRequester requester)
    {
        _signInManager = signInManager;
        Requester = requester;
    }

    [HttpPost]
    [Route("Login")]
    public async Task<IActionResult> Login(LoginData lData)
    {
        var loginResult = await _signInManager
            .PasswordSignInAsync(lData.Identifier, lData.Password, false, false);
        var user = loginResult.Succeeded ? await Requester.GetUserByUsername(lData.Identifier) : null;
        return new JsonResult(new LoginResult(loginResult.Succeeded, user));
    }
}