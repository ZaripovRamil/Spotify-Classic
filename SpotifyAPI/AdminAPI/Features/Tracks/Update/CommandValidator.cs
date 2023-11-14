using DatabaseServices.Repositories;
using FluentValidation;
using static Utils.CQRS.Validation.CommonValidationHandlers;
using static Models.ValidationErrors.EntityErrors;
using static Models.ValidationErrors.TrackErrors;

namespace AdminAPI.Features.Tracks.Update;

public class CommandValidator : AbstractValidator<Command>
{
    private readonly ITrackRepository _trackRepository;

    public CommandValidator(ITrackRepository trackRepository)
    {
        _trackRepository = trackRepository;
        
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

        RuleFor(c => c.Id)
            .MustAsync(Exist)
            .WithMessage(TrackNotFound);
    }

    private async Task<bool> Exist(string trackId, CancellationToken cancellationToken = default) =>
        await _trackRepository.GetByIdAsync(trackId) is not null;
}