using AuthAPI.Dto;
using Google.Apis.Auth;
using Microsoft.AspNetCore.Identity;
using Models.Entities;
using Utils.CQRS;

namespace AuthAPI.Features.SignUp.OAuth;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly UserManager<User> _userManager;

    public CommandHandler(UserManager<User> userManager)
    {
        _userManager = userManager;
    }

    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        var loginData = request.LoginData;
        var payload = await GoogleJsonWebSignature.ValidateAsync(loginData.IdToken);
        var user = new User(payload.Subject, payload.Email, payload.Name);
        var password = Guid.NewGuid().ToString();
        var result = await _userManager.CreateAsync(user, password);
        if (!result.Succeeded)
            return new Result<ResultDto>(new ResultDto(new RegistrationResult(RegistrationCode.UnknownError, null)));
        await _userManager.AddLoginAsync(user, new UserLoginInfo("Google", payload.Subject, "OAuth"));
        return new Result<ResultDto>(new ResultDto(new RegistrationResult(RegistrationCode.Successful,
            await _userManager.FindByEmailAsync(payload.Email))));
    }
}