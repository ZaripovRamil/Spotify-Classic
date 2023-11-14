using DatabaseServices.Repositories;
using Models.Entities;
using Utils.CQRS;

namespace UserAPI.Features.Playlists.Create;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly IPlaylistRepository _playlistRepository;

    public CommandHandler(IPlaylistRepository playlistRepository)
    {
        _playlistRepository = playlistRepository;
    }

    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        var playlist = new Playlist(request.Name, request.OwnerId);
        await _playlistRepository.AddAsync(playlist);
        return new ResultDto(true, "Successful", playlist.OwnerId);
    }
}