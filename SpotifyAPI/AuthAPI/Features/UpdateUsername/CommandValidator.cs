using FluentValidation;
using static Models.ValidationErrors.UserErrors;

namespace AuthAPI.Features.UpdateUsername;

public class CommandValidator : AbstractValidator<Command>
{
    public CommandValidator()
    {
        RegisterRules();
    }

    private void RegisterRules()
    {
        RuleFor(c => c.Username)
            .Must(BeValid)
            .WithMessage(InvalidUsername);
    }
    
    private static bool BeValid(string username) => username.All(char.IsLetterOrDigit) && username.Length >= 4;
}