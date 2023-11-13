using DatabaseServices.Repositories;
using Models.DTO.BackToFront.Full;
using Models.Entities;
using Utils.CQRS;
using static AdminAPI.Features.Albums.Get.ByFilters.Spec;

namespace AdminAPI.Features.Albums.Get.ByFilters;

public class QueryHandler : IQueryHandler<Query, IEnumerable<AlbumFull>>
{
    private readonly IAlbumRepository _albumRepository;

    private static Func<Album, IComparable> Sort(string? param) => param?.ToLower() switch
    {
        "id" => album => album.Id,
        "name" => album => album.Name,
        "author" => album => album.Author.Name,
        "type" => album => album.Type,
        _ => album => album.Name
    };

    public QueryHandler(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    public async Task<Result<IEnumerable<AlbumFull>>> Handle(Query request, CancellationToken cancellationToken)
    {
        var albums = await _albumRepository.FilterAsync(
                OfType(request.AlbumType) &&
                HasTracksNoLessThan(request.TracksMin) &&
                HasTracksNoMoreThan(request.TracksMax) &&
                ContainsTextInName(request.Search))
            .Take(request.MaxCount ?? 50)
            .OrderBy(Sort(request.SortBy))
            .Select(a => new AlbumFull(a))
            .ToListAsync(cancellationToken: cancellationToken);

        return new Result<IEnumerable<AlbumFull>>(albums);
    }
}