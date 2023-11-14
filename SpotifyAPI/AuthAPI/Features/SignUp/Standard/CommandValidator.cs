using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Models.Entities;
using static Models.ValidationErrors.UserErrors;

namespace AuthAPI.Features.SignUp.Standard;

public class CommandValidator : AbstractValidator<Command>
{
    private readonly UserManager<User> _userManager;

    public CommandValidator(UserManager<User> userManager)
    {
        _userManager = userManager;
        
        RegisterRules();
    }

    private void RegisterRules()
    {
        RuleFor(c => c.RegistrationData.Password)
            .Must(HaveEnoughChars)
            .WithMessage(WeakPassword);

        RuleFor(c => c.RegistrationData.Login)
            .Must(BeValid)
            .WithMessage(InvalidUsername);

        RuleFor(c => c.RegistrationData.Email)
            .MustAsync(EmailNotBeTaken)
            .WithMessage(EmailTaken);

        RuleFor(c => c.RegistrationData.Login)
            .MustAsync(LoginNotBeTaken)
            .WithMessage(LoginTaken);
    }

    private static bool HaveEnoughChars(string password) => password.Length >= 8;
    
    private static bool BeValid(string username) => username.All(char.IsLetterOrDigit) && username.Length >= 4;

    private async Task<bool> EmailNotBeTaken(string email, CancellationToken cancellationToken) =>
        await _userManager.FindByEmailAsync(email) is null;

    private async Task<bool> LoginNotBeTaken(string login, CancellationToken cancellationToken) =>
        await _userManager.FindByEmailAsync(login) is null;
}