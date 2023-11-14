using DatabaseServices.Repositories;
using FluentValidation;
using static Models.ValidationErrors.PlaylistErrors;
using static Models.ValidationErrors.TrackErrors;

namespace UserAPI.Features.Playlists.AddTracks;

public class CommandValidator : AbstractValidator<Command>
{
    private readonly IPlaylistRepository _playlistRepository;
    private readonly ITrackRepository _trackRepository;

    public CommandValidator(IPlaylistRepository playlistRepository, ITrackRepository trackRepository)
    {
        _playlistRepository = playlistRepository;
        _trackRepository = trackRepository;

        RegisterRules();
    }

    private void RegisterRules()
    {
        RuleFor(c => c.PlaylistId)
            .MustAsync(Exist)
            .WithMessage(PlaylistNotFound);

        RuleFor(c => c.TrackIds)
            .MustAsync(TracksExist)
            .WithMessage(TrackNotFound);

        RuleFor(c => c)
            .MustAsync(UserOwnPlaylist)
            .WithMessage(OwnerDoesNotMatch);
    }

    private async Task<bool> Exist(string id, CancellationToken cancellationToken) =>
        await _playlistRepository.GetByIdAsync(id) is not null;

    private async Task<bool> TracksExist(List<string> tracksIds, CancellationToken cancellationToken)
    {
        foreach (var trackId in tracksIds)
            if (await _trackRepository.GetByIdAsync(trackId) is null)
                return false;

        return true;
    }

    private async Task<bool> UserOwnPlaylist(Command command, CancellationToken cancellationToken) =>
        (await _playlistRepository.GetByIdAsync(command.PlaylistId))!.OwnerId == command.AdderUserId;
}