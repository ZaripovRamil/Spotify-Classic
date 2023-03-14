
using AuthService.Services;
using Microsoft.AspNetCore.Mvc;
using Models.DTO;


namespace AuthService.Controllers;

[ApiController]
[Route("register")]
public class RegistrationController
{
    private IDbRequester Requester { get; }

    public RegistrationController(IDbRequester requester)
    {
        this.Requester = requester;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody]RegistrationData rData)
    {
        if (await Requester.GetUserByLogin(rData.Login) != null)
            return new JsonResult(RegistrationCode.LoginTaken);
        if (await Requester.GetUserByEmail(rData.Email) != null)
            return new JsonResult(RegistrationCode.EmailTaken);
        if (rData.Password.Length < 8)
            return new JsonResult(RegistrationCode.WeakPassword); 
        Requester.AddUserToDb(rData);
        return new JsonResult(RegistrationCode.Successful);
    }
}