using DatabaseServices.Repositories;
using FluentValidation;
using static Models.ValidationErrors.PlaylistErrors;

namespace UserAPI.Features.Playlists.Delete;

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
        RuleFor(c => c.Id)
            .MustAsync(Exist)
            .WithMessage(PlaylistNotFound);

        RuleFor(c => c)
            .MustAsync(UserPossessesPlaylist)
            .WithMessage(OwnerDoesNotExist);
    }

    private async Task<bool> Exist(string id, CancellationToken cancellationToken) =>
        await _playlistRepository.GetByIdAsync(id) is not null;

    private async Task<bool> UserPossessesPlaylist(Command command, CancellationToken cancellationToken) =>
        (await _playlistRepository.GetByIdAsync(command.Id))?.OwnerId == command.DeleterId;
}