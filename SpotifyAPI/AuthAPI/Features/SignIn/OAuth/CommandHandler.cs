using AuthAPI.Dto.OAuth;
using Google.Apis.Auth;
using Microsoft.AspNetCore.Identity;
using Models.DTO.BackToFront.Auth;
using Models.Entities;
using Utils.CQRS;

namespace AuthAPI.Features.SignIn.OAuth;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly UserManager<User> _userManager;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly Features.SignUp.OAuth.CommandHandler _commandHandler;

    public CommandHandler(UserManager<User> userManager, IJwtTokenGenerator jwtTokenGenerator,
        SignUp.OAuth.CommandHandler commandHandler)
    {
        _userManager = userManager;
        _jwtTokenGenerator = jwtTokenGenerator;
        _commandHandler = commandHandler;
    }

    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        var loginData = request.LoginData;
        var payload = await GoogleJsonWebSignature.ValidateAsync(loginData.IdToken);
        var user = await _userManager.FindByLoginAsync("Google", payload.Subject);
        if (user is null && await _userManager.FindByEmailAsync(payload.Email) is null)
        {
            var registerResult = await RegisterAsync(loginData);
            if (!registerResult.IsSuccessful) return registerResult;
        }

        user = await _userManager.FindByEmailAsync(payload.Email);
        var additionalLifetime = await _jwtTokenGenerator.GetRoleAsync(payload.Subject) != "Admin"
            ? TimeSpan.FromDays(14)
            : TimeSpan.Zero;
        var token = await _jwtTokenGenerator.GenerateJwtTokenAsync(user!.UserName!, additionalLifetime);
        return token is null
            ? new Result<ResultDto>(new ResultDto(new LoginResult(false, "", "Authorization failed")))
            : new Result<ResultDto>(new ResultDto(new LoginResult(true, token, "Successful")));
    }

    private async Task<Result<ResultDto>> RegisterAsync(GoogleLoginData loginData)
    {
        var command = new Features.SignUp.OAuth.Command(loginData);
        var regResult = await _commandHandler.Handle(command, new CancellationToken(false));
        var result = new Result<ResultDto>(new ResultDto(null!));
        if (!regResult.IsSuccessful)
            result.Fail();
        return result;
    }
}