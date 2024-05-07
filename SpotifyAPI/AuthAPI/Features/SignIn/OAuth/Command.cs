using Models.DTO.OAuth;
using Utils.CQRS;

namespace AuthAPI.Features.SignIn.OAuth;

public record Command(GoogleLoginData LoginData) : ICommand<ResultDto>;