using Microsoft.AspNetCore.Identity;
using Models.Entities;
using Utils.CQRS;

namespace AuthAPI.Features.SignIn.Standard;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly SignInManager<User> _signInManager;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly UserManager<User> _userManager;

    public CommandHandler(SignInManager<User> signInManager, IJwtTokenGenerator jwtTokenGenerator, UserManager<User> userManager)
    {
        _signInManager = signInManager;
        _jwtTokenGenerator = jwtTokenGenerator;
        _userManager = userManager;
    }

    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        var loginData = request.LoginData;
        if (loginData.Username is null || loginData.Password is null)
            return new Result<ResultDto>(new ResultDto(new LoginResult(false, "", "Empty login or/and password")));
        var user = await _userManager.FindByNameAsync(request.LoginData.Username);
        if (user is null)
            return new Result<ResultDto>(new ResultDto(new LoginResult(false, "", "No such a user")));
        var loginResult = await _signInManager
            .CheckPasswordSignInAsync(user, loginData.Password, false);
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
            return new Result<ResultDto>(new ResultDto(new LoginResult(false, "", errorMessage)));
        }

        // admins are not allowed to be authorized more than one hour
        var additionalLifetime =
            loginData.RememberMe && await _jwtTokenGenerator.GetRoleAsync(loginData.Username) != "Admin"
                ? TimeSpan.FromDays(14)
                : TimeSpan.Zero;
        var token = await _jwtTokenGenerator.GenerateJwtTokenAsync(loginData.Username, additionalLifetime);
        return token is null
            ? new Result<ResultDto>(new ResultDto(new LoginResult(false, "", "Authorization failed")))
            : new Result<ResultDto>(new ResultDto(new LoginResult(true, token, "Successful")));
    }
}