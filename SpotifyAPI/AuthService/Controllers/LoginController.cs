using Microsoft.AspNetCore.Mvc;
using Models.DTO;
using static AuthService.Services.DbRequester;
using static Models.Services.HashingService;
namespace AuthService.Controllers;

[ApiController]
[Route("login")]
public class LoginController
{
    [HttpPost]
    public async Task<IActionResult> ValidateLogin(LoginData lData)
    {
        var user = await GetUserByLogin(lData.Identifier) ?? await GetUserByEmail(lData.Identifier);
        if (user != null && IsValidPassword(lData.Password, user.Salt, user.Password))
            return new JsonResult(user);
        return new JsonResult(null);
    }

    private static bool IsValidPassword(string attemptedPassword, string userSalt, string hashedPassword)
    {
        return GenerateHash(attemptedPassword, userSalt) == hashedPassword;
    }
}