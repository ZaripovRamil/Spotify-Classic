using DatabaseServices.Repositories;
using Models.DTO.BackToFront.Full;
using Utils.CQRS;

namespace PlayerAPI.Features.GetPlaylistById;

public class QueryHandler: IQueryHandler<Query, PlaylistFull>
{
    private const string PlaylistNotFound = "Playlist Not Found";
    private readonly IPlaylistRepository _playlistRepository;

    public QueryHandler(IPlaylistRepository playlistRepository)
    {
        _playlistRepository = playlistRepository;
    }

    public async Task<Result<PlaylistFull>> Handle(Query request, CancellationToken cancellationToken)
    {
        var playlist =  await _playlistRepository.GetByIdAsync(request.Id);
        return playlist is null ? new Result<PlaylistFull>(PlaylistNotFound) : new Result<PlaylistFull>(new PlaylistFull(playlist));
    }
}