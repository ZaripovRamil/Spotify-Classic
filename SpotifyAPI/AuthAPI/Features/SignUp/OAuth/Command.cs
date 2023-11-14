using AuthAPI.Dto.OAuth;
using Utils.CQRS;

namespace AuthAPI.Features.SignUp.OAuth;

public record Command(GoogleLoginData LoginData) : ICommand<ResultDto>;