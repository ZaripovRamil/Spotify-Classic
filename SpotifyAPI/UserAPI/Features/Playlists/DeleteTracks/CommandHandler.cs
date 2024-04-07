using DatabaseServices.Repositories;
using UserAPI.Dto;
using Utils.CQRS;
using static Models.ValidationErrors.CommonConstants;

namespace UserAPI.Features.Playlists.DeleteTracks;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly IPlaylistRepository _playlistRepository;

    public CommandHandler(IPlaylistRepository playlistRepository)
    {
        _playlistRepository = playlistRepository;
    }

    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        await _playlistRepository.DeleteTracksAsync(request.PlaylistId, request.TrackIds);
        return new ResultDto(true, Successful);
    }
}