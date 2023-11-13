using FluentValidation;
using Models.DTO.FrontToBack.EntityUpdateData;

namespace AuthAPI.Features.UpdatePassword;

public class CommandValidator : AbstractValidator<Command>
{
    public CommandValidator()
    {
        RegisterRules();
    }

    private void RegisterRules()
    {
        RuleFor(c => c.Data)
            .Must(PasswordsMatch)
            .WithMessage("Old password mismatch");
    }

    private static bool PasswordsMatch(PasswordUpdateData data)
    {
        return data.OldPassword == data.RepeatPassword;
    }
}