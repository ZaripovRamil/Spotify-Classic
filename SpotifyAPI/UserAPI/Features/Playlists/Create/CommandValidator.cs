using DatabaseServices.Repositories;
using FluentValidation;
using static Utils.CQRS.Validation.CommonValidationHandlers;
using static Models.ValidationErrors.EntityErrors;
using static Models.ValidationErrors.PlaylistErrors;

namespace UserAPI.Features.Playlists.Create;

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

        RuleFor(c => c.OwnerId)
            .MustAsync(Exist)
            .WithMessage(OwnerDoesNotExist);
    }

    private async Task<bool> Exist(string ownerId, CancellationToken cancellationToken = default) =>
        await _userRepository.GetByIdAsync(ownerId) is not null;
}