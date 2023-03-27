using AuthService.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.DTO;
using Models.Services;
namespace AuthService.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class AuthController
{
    private readonly SignInManager<User> _signInManager;
    private IDbRequester Requester { get; }

    public AuthController(SignInManager<User> signInManager,  IDbRequester requester)
    {
        _signInManager = signInManager;
        Requester = requester;
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginData lData)
    {
        var loginResult = await _signInManager
            .PasswordSignInAsync(lData.Identifier, lData.Password, false, false);
        return loginResult.Succeeded ? new JsonResult(await Requester.GetUserByLogin(lData.Identifier)) : new JsonResult("Wrong credentials");
    }
}