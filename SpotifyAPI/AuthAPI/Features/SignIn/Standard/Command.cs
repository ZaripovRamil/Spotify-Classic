using Models.DTO.FrontToBack.Auth;
using Utils.CQRS;

namespace AuthAPI.Features.SignIn.Standard;

public record Command(LoginData LoginData) : ICommand<ResultDto>;