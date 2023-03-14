using AuthService.Services;
using Microsoft.AspNetCore.Mvc;
using Models.DTO;
using static AuthService.Services.DbRequester;

namespace AuthService.Controllers;

[ApiController]
[Route("register")]
public class RegistrationController
{
    
    [HttpPost]
    public async Task<IActionResult> Add([FromBody]RegistrationData rData)
    {
        if (await GetUserByLogin(rData.Login) != null)
            return new JsonResult(RegistrationCode.LoginTaken);
        if (await GetUserByEmail(rData.Email) != null)
            return new JsonResult(RegistrationCode.EmailTaken);
        if (rData.Password.Length < 8)
            return new JsonResult(RegistrationCode.WeakPassword);
        AddUserToDb(rData);
        return new JsonResult(RegistrationCode.Successful);
    }
}