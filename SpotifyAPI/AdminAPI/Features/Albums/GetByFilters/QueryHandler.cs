using DatabaseServices.Repositories;
using Models.DTO.BackToFront.Full;
using Utils.CQRS;

namespace AdminAPI.Features.Albums.GetByFilters;

public class QueryHandler : IQueryHandler<Query, IEnumerable<AlbumFull>>
{
    private readonly IAlbumRepository _albumRepository;

    public QueryHandler(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    public async Task<Result<IEnumerable<AlbumFull>>> Handle(Query request, CancellationToken cancellationToken)
    {
        var albums = await _albumRepository.FilterAsync(a =>
                (request.AlbumType == null || a.Type.ToString().ToLower() == request.AlbumType.ToLower()) &&
                (request.TracksMin == null || a.Tracks.Count >= request.TracksMin.Value) &&
                (request.TracksMax == null || a.Tracks.Count <= request.TracksMax.Value) &&
                (request.Search == null || a.Name.ToLower().Contains(request.Search.ToLower())))
            .Take(request.MaxCount ?? 50)
            .Select(a => new AlbumFull(a))
            .ToListAsync(cancellationToken: cancellationToken);
        Func<AlbumFull, IComparable> sort = request.SortBy?.ToLower() switch
        {
            "id" => album => album.Id,
            "name" => album => album.Name,
            "author" => album => album.Author.Name,
            "type" => album => album.Type,
            _ => album => album.Name
        };

        return new Result<IEnumerable<AlbumFull>>(albums.OrderBy(sort));
    }
}