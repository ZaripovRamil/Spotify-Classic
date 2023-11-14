using DatabaseServices.Repositories;
using FluentValidation;
using static Models.ValidationErrors.PlaylistErrors;

namespace UserAPI.Features.Playlists.DeleteTracks;

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
        RuleFor(c => c.PlaylistId)
            .MustAsync(Exist)
            .WithMessage(OwnerDoesNotMatch);

        RuleFor(c => c)
            .MustAsync(UserOwnPlaylist)
            .WithMessage(OwnerDoesNotMatch);
    }

    private async Task<bool> Exist(string id, CancellationToken cancellationToken) =>
        await _playlistRepository.GetByIdAsync(id) is not null;

    private async Task<bool> UserOwnPlaylist(Command command, CancellationToken cancellationToken)
    {
        var playlist = await _playlistRepository.GetByIdAsync(command.PlaylistId);
        return playlist?.OwnerId == command.DeleterUserId;
    }
}