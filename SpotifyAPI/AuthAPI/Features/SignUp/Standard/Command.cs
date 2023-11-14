using Utils.CQRS;

namespace AuthAPI.Features.SignUp.Standard;

public record Command(RegistrationData RegistrationData) : ICommand<ResultDto>;