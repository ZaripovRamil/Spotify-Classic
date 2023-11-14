using DatabaseServices.Repositories;
using Models.DTO.Full;
using Utils.CQRS;

namespace UserAPI.Features.Playlists.Get.AllByUserId;

public class QueryHandler : IQueryHandler<Query, IEnumerable<PlaylistFull>>
{
    private readonly IPlaylistRepository _playlistRepository;

    public QueryHandler(IPlaylistRepository playlistRepository)
    {
        _playlistRepository = playlistRepository;
    }

    public async Task<Result<IEnumerable<PlaylistFull>>> Handle(Query request, CancellationToken cancellationToken)
    {
        return await _playlistRepository.FilterAsync(p => p.OwnerId == request.UserId)
            .Select(p => new PlaylistFull(p)).ToListAsync(cancellationToken: cancellationToken);
    }
}