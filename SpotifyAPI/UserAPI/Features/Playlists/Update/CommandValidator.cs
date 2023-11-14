using DatabaseServices.Repositories;
using FluentValidation;
using static Utils.CQRS.Validation.CommonValidationHandlers;
using static Models.ValidationErrors.EntityErrors;
using static Models.ValidationErrors.PlaylistErrors;

namespace UserAPI.Features.Playlists.Update;

public class CommandValidator : AbstractValidator<Command>
{
    private readonly IPlaylistRepository _playlistRepository;

    public CommandValidator(IPlaylistRepository playlistRepository)
    {
        _playlistRepository = playlistRepository;
        
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

        RuleFor(c => c.PlaylistId)
            .MustAsync(Exist)
            .WithMessage(PlaylistNotFound);
    }

    private async Task<bool> Exist(string playlistId, CancellationToken cancellationToken = default) =>
        await _playlistRepository.GetByIdAsync(playlistId) is not null;
}