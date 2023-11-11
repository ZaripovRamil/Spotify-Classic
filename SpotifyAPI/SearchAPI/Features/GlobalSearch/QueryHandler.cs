using DatabaseServices.Repositories;
using Models.DTO.BackToFront.Light;
using Utils.CQRS;

namespace SearchAPI.Features.GlobalSearch;

public class QueryHandler : IQueryHandler<Query, ResultDto>
{
    private readonly ITrackRepository _trackRepository;
    private readonly IAlbumRepository _albumRepository;
    private readonly IAuthorRepository _authorRepository;
    private readonly IPlaylistRepository _playlistRepository;

    public QueryHandler(ITrackRepository trackRepository, IAuthorRepository authorRepository,
        IPlaylistRepository playlistRepository, IAlbumRepository albumRepository)
    {
        _authorRepository = authorRepository;
        _playlistRepository = playlistRepository;
        _albumRepository = albumRepository;
        _trackRepository = trackRepository;
    }

    public async Task<Result<ResultDto>> Handle(Query request, CancellationToken cancellationToken)
    {
        // .Take(10) now works in server memory, which is not good
        return new ResultDto(
            await _trackRepository
                .FilterAsync(TrackSpec.NameContains(request.Filter))
                .Take(10)
                .Select(t => new TrackLight(t))
                .ToListAsync(cancellationToken: cancellationToken),

            await _albumRepository
                .FilterAsync(AlbumSpec.NameContains(request.Filter))
                .Take(10)
                .Select(a => new AlbumLight(a))
                .ToListAsync(cancellationToken: cancellationToken),

            await _authorRepository
                .FilterAsync(AuthorSpec.NameContains(request.Filter))
                .Take(10)
                .Select(a => new AuthorLight(a))
                .ToListAsync(cancellationToken: cancellationToken),

            await _playlistRepository
                .FilterAsync(PlaylistSpec.NameContains(request.Filter))
                .Take(10)
                .Select(p => new PlaylistLight(p))
                .ToListAsync(cancellationToken: cancellationToken));
    }
}