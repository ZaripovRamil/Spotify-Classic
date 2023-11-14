using DatabaseServices.Repositories;
using FluentValidation;
using static Utils.CQRS.Validation.CommonValidationHandlers;
using static Models.ValidationErrors.EntityErrors;
using static Models.ValidationErrors.AuthorErrors;

namespace AdminAPI.Features.Authors.Create;

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
        RuleFor(c => c.Name)
            .Must(BeNotNullNotEmpty)
            .WithMessage(FieldEmpty(nameof(Command.Name)));
        
        RuleFor(c => c.Name)
            .Must(ContainOnlyAllowedCharacters)
            .WithMessage(FieldContainsUnacceptableCharacters(nameof(Command.Name)));

        RuleFor(c => c.UserId)
            .MustAsync(Exist)
            .WithMessage(UserNotFound);
    }

    private async Task<bool> Exist(string userId, CancellationToken cancellationToken = default) =>
        await _userRepository.GetByIdAsync(userId) is not null;
}