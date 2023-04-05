using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;


namespace AuthService.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class RegistrationController
{
    private readonly UserManager<User> _userManager; 

    public RegistrationController(UserManager<User> userManager)
    {
        _userManager = userManager;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody]RegistrationData rData)
    {
        if (await _userManager.FindByEmailAsync(rData.Email) != null)
            return new JsonResult(RegistrationCode.EmailTaken);
        if (await _userManager.FindByNameAsync(rData.Login) != null)
            return new JsonResult(RegistrationCode.LoginTaken);
        if (rData.Password.Length < 8)
            return new JsonResult(RegistrationCode.WeakPassword);
        var regResult = await _userManager.CreateAsync(new User(rData.Login, rData.Email, rData.Name), rData.Password);
        return regResult.Succeeded
            ? new JsonResult(RegistrationCode.Successful)
            : new JsonResult(RegistrationCode.UnknownError);
    }
}