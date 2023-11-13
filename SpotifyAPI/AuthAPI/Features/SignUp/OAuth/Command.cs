using AuthAPI.Dto.OAuth;
using AuthAPI.Features.SignIn.OAuth;
using Utils.CQRS;

namespace AuthAPI.Features.SignUp.OAuth;

public record Command(GoogleLoginData LoginData) : ICommand<ResultDto>;