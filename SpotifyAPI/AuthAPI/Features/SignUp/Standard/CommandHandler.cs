using Microsoft.AspNetCore.Identity;
using Models.DTO.BackToFront.Auth;
using Models.Entities;
using Utils.CQRS;

namespace AuthAPI.Features.SignUp.Standard;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly UserManager<User> _userManager;

    public CommandHandler(UserManager<User> userManager)
    {
        _userManager = userManager;
    }

    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        var rData = request.RegistrationData;
        if (rData.Password.Length < 8)
            return new Result<ResultDto>(new ResultDto(new RegistrationResult(RegistrationCode.WeakPassword, null)));
        if (!ValidateUsername(rData.Login))
            return new Result<ResultDto>(new ResultDto(new RegistrationResult(RegistrationCode.InvalidUsername, null)));
        if (await _userManager.FindByEmailAsync(rData.Email) != null)
            return new Result<ResultDto>(new ResultDto(new RegistrationResult(RegistrationCode.EmailTaken, null)));
        if (await _userManager.FindByNameAsync(rData.Login) != null)
            return new Result<ResultDto>(new ResultDto(new RegistrationResult(RegistrationCode.LoginTaken, null)));
        var regResult = await _userManager.CreateAsync(new User(rData.Login, rData.Email, rData.Name), rData.Password);
        return regResult.Succeeded
            ? new Result<ResultDto>(new ResultDto(new RegistrationResult(RegistrationCode.Successful,
                await _userManager.FindByEmailAsync(rData.Email))))
            : new Result<ResultDto>(new ResultDto(new RegistrationResult(RegistrationCode.UnknownError, null)));
    }

    private static bool ValidateUsername(string username)
    {
        return username.All(char.IsLetterOrDigit) && username.Length >= 4;
    }
}