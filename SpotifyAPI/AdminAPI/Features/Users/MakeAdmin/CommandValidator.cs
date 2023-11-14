using DatabaseServices.Repositories;
using FluentValidation;
using static Models.ValidationErrors.UserErrors;

namespace AdminAPI.Features.Users.MakeAdmin;

public class CommandValidator : AbstractValidator<Command>
{
    private readonly IUserRepository _userRepository;

    public CommandValidator(IUserRepository userRepository)
    {
        _userRepository = userRepository;

        RegisterRules();
    }

    private void RegisterRules()
    {
        RuleFor(c => 0)
            .Must(EnvironmentBeDevelopment)
            .WithMessage("Not found");
        
        RuleFor(c => c.Login)
            .MustAsync(Exist)
            .WithMessage(UserNotFound);
    }

    private static bool EnvironmentBeDevelopment(int _) =>
        Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development";

    private async Task<bool> Exist(string login, CancellationToken cancellationToken) =>
        await _userRepository.GetByNameAsync(login) is not null;
}