using AuthAPI.Dto.OAuth;
using Google.Apis.Auth;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Models.DTO.Auth;
using Models.Entities;
using Utils.CQRS;
using static Models.ValidationErrors.CommonConstants;

namespace AuthAPI.Features.SignIn.OAuth;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly UserManager<User> _userManager;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IMediator _mediator;

    public CommandHandler(UserManager<User> userManager, IJwtTokenGenerator jwtTokenGenerator, IMediator mediator)
    {
        _userManager = userManager;
        _jwtTokenGenerator = jwtTokenGenerator;
        _mediator = mediator;
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
            ? new Result<ResultDto>(new ResultDto(new LoginResult(false, string.Empty, "Authorization failed")))
            : new Result<ResultDto>(new ResultDto(new LoginResult(true, token, Successful)));
    }

    private async Task<Result<ResultDto>> RegisterAsync(GoogleLoginData loginData)
    {
        var command = new Features.SignUp.OAuth.Command(loginData);
        var regResult = await _mediator.Send(command);
        var result = new Result<ResultDto>(new ResultDto(null!));
        if (!regResult.IsSuccessful)
            result.Fail();
        return result;
    }
}