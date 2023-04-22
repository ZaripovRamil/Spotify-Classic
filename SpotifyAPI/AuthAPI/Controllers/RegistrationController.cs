using DatabaseServices.Services.Accessors.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.Auth;
using Models.DTO.FrontToBack.Auth;
using Models.Entities;


namespace AuthService.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class RegistrationController
{
    private readonly UserManager<User> _userManager;
    private readonly IDbUserAccessor _userAccessor;

    public RegistrationController(UserManager<User> userManager, IDbUserAccessor userAccessor)
    {
        _userManager = userManager;
        _userAccessor = userAccessor;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] RegistrationData rData)
    {
        if (await _userManager.FindByEmailAsync(rData.Email) != null)
            return new JsonResult(new RegistrationResult(RegistrationCode.EmailTaken, null));
        if (await _userManager.FindByNameAsync(rData.Login) != null)
            return new JsonResult(new RegistrationResult(RegistrationCode.LoginTaken, null));
        if (rData.Password.Length < 8)
            return new JsonResult(new RegistrationResult(RegistrationCode.WeakPassword, null));
        var regResult = await _userManager.CreateAsync(new User(rData.Login, rData.Email, rData.Name), rData.Password);
        return regResult.Succeeded
            ? new JsonResult(new RegistrationResult(RegistrationCode.Successful,
                await _userAccessor.GetByEmail(rData.Email)))
            : new JsonResult(new RegistrationResult(RegistrationCode.UnknownError, null));
    }
}