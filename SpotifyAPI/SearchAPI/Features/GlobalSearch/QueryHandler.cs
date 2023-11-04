using DatabaseServices.Services.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;
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
        return new ResultDto(
            await _trackRepository.GetAll()
                .Where(TrackSpec.NameContains(request.Filter))
                .Take(10)
                .AsAsyncEnumerable()
                .Select(t => new TrackLight(t))
                .ToListAsync(cancellationToken: cancellationToken),

            await _albumRepository.GetAll()
                .Where(AlbumSpec.NameContains(request.Filter))
                .Take(10)
                .AsAsyncEnumerable()
                .Select(a => new AlbumLight(a))
                .ToListAsync(cancellationToken: cancellationToken),

            await _authorRepository.GetAll()
                .Where(AuthorSpec.NameContains(request.Filter))
                .Take(10)
                .AsAsyncEnumerable()
                .Select(a => new AuthorLight(a))
                .ToListAsync(cancellationToken: cancellationToken),

            await _playlistRepository.GetAll()
                .Where(PlaylistSpec.NameContains(request.Filter))
                .Take(10)
                .AsAsyncEnumerable()
                .Select(p => new PlaylistLight(p))
                .ToListAsync(cancellationToken: cancellationToken));
    }
}