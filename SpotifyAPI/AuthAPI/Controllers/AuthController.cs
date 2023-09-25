using AuthAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.Auth;
using Models.DTO.FrontToBack.Auth;
using Models.Entities;

namespace AuthAPI.Controllers;

[AllowAnonymous]
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
    public async Task<IActionResult> Login(LoginData loginData)
    {
        var loginResult = await _signInManager
            .PasswordSignInAsync(loginData.Username, loginData.Password, loginData.RememberMe, false);
        if (!loginResult.Succeeded)
        {
            string errorMessage;
            if (loginResult.IsLockedOut)
                errorMessage = "You're locked";
            else if (loginResult.IsNotAllowed)
                errorMessage = "You're not allowed no sign-in";
            else
                errorMessage = loginResult.RequiresTwoFactor
                    ? "Two factor authentication is required"
                    : "No such a user";
            return new JsonResult(new LoginResult(false, "", errorMessage));
        }

        // admins are not allowed to be authorized more than one hour
        var additionalLifetime =
            loginData.RememberMe && await _jwtTokenGenerator.GetRoleAsync(loginData.Username) != "Admin"
                ? TimeSpan.FromDays(14)
                : TimeSpan.Zero;
        var token = await _jwtTokenGenerator.GenerateJwtTokenAsync(loginData.Username, additionalLifetime);
        return token is null
            ? new JsonResult(new LoginResult(false, "", "Authorization failed"))
            : new JsonResult(new LoginResult(true, token, "Successful"));
    }
}