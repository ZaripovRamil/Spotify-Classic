using AuthAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.Auth;
using Models.DTO.FrontToBack.Auth;
using Models.Entities;

namespace AuthAPI.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class AuthController : Controller
{
    private readonly SignInManager<User> _signInManager;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthController(SignInManager<User> signInManager, IJwtTokenGenerator jwtTokenGenerator)
    {
        _signInManager = signInManager;
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Login(LoginData loginData)
    {
        var loginResult = await _signInManager
            .PasswordSignInAsync(loginData.Username, loginData.Password, false, false);
        if (!loginResult.Succeeded)
        {
            var errorMessage = loginResult.IsLockedOut ? "You're locked" :
                loginResult.IsNotAllowed ? "You're not allowed no sign-in" :
                loginResult.RequiresTwoFactor ? "Two factor authentication is required" : "No such a user";
            return new JsonResult(new LoginResult(false, "", errorMessage));
        }
        var token = await _jwtTokenGenerator.GenerateJwtTokenAsync(loginData.Username);
        return token is null
            ? new JsonResult(new LoginResult(false, "", "Authorization failed"))
            : new JsonResult(new LoginResult(true, token, "Successful"));
    }
}