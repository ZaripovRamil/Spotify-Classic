using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.DTO;


namespace AuthService.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
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
        var regResult = await _userManager.CreateAsync(new User {UserName = rData.Login, Email = rData.Email, Name = rData.Name, Role = Role.Free}, rData.Password);
        if(regResult.Succeeded)
            return new JsonResult(RegistrationCode.Successful);
        return new JsonResult(RegistrationCode.UnknownError);
    }
}