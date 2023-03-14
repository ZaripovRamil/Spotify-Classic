using AuthService.Services;
using Microsoft.AspNetCore.Mvc;
using Models.DTO;
using Models.Services;
namespace AuthService.Controllers;

[ApiController]
[Route("login")]
public class LoginController
{
    private IHashingService HashingService { get; }
    private IDbRequester Requester { get; }
    public LoginController(IHashingService hashingService, IDbRequester requester)
    {
        HashingService = hashingService;
        Requester = requester;
    }

    [HttpPost]
    public async Task<IActionResult> ValidateLogin(LoginData lData)
    {
        var user = await Requester.GetUserByLogin(lData.Identifier) ?? await Requester.GetUserByEmail(lData.Identifier);
        if (user != null && IsValidPassword(lData.Password, user.Salt, user.Password))
            return new JsonResult(user);
        return new JsonResult(null);
    }

    private bool IsValidPassword(string attemptedPassword, string userSalt, string hashedPassword)
    {
        return HashingService.GenerateHash(attemptedPassword, userSalt) == hashedPassword;
    }
}