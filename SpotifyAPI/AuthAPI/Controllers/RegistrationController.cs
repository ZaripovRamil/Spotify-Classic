using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.Auth;
using Models.DTO.FrontToBack.Auth;
using Models.Entities;

namespace AuthAPI.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class RegistrationController : Controller
{
    private readonly UserManager<User> _userManager;

    public RegistrationController(UserManager<User> userManager)
    {
        _userManager = userManager;
    }

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Add([FromBody] RegistrationData rData)
    {
        if (rData.Password.Length < 8)
            return new JsonResult(new RegistrationResult(RegistrationCode.WeakPassword, null));
        if (!ValidateUsername(rData.Login))
            return new JsonResult(new RegistrationResult(RegistrationCode.InvalidUsername, null));
        if (await _userManager.FindByEmailAsync(rData.Email) != null)
            return new JsonResult(new RegistrationResult(RegistrationCode.EmailTaken, null));
        if (await _userManager.FindByNameAsync(rData.Login) != null)
            return new JsonResult(new RegistrationResult(RegistrationCode.LoginTaken, null));
        var regResult = await _userManager.CreateAsync(new User(rData.Login, rData.Email, rData.Name), rData.Password);
        return regResult.Succeeded
            ? new JsonResult(new RegistrationResult(RegistrationCode.Successful,
                await _userManager.FindByEmailAsync(rData.Email)))
            : new JsonResult(new RegistrationResult(RegistrationCode.UnknownError, null));
    }

    private static bool ValidateUsername(string username)
    {
        return username.All(char.IsLetterOrDigit) && username.Length >= 4;
    }
}