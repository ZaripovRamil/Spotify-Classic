using DatabaseServices.Repositories;
using FluentValidation;
using static Models.Entities.ValidationErrors.TrackErrors;

namespace AdminAPI.Features.Tracks.Delete;

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
        RuleFor(c => c.Id)
            .MustAsync(Exist)
            .WithMessage(TrackNotFound);
    }

    private async Task<bool> Exist(string id, CancellationToken cancellationToken) =>
        await _trackRepository.GetByIdAsync(id) is not null;
}