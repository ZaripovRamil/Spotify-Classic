using DatabaseServices.Repositories;
using Models.DTO.Full;
using Models.Entities;
using Utils.CQRS;
using static AdminAPI.Features.Tracks.Get.ByFilters.Spec;

namespace AdminAPI.Features.Tracks.Get.ByFilters;

public class QueryHandler : IQueryHandler<Query, IEnumerable<TrackFull>>
{
    private readonly ITrackRepository _trackRepository;

    private static Func<Track, IComparable> Sort(string? param) => param?.ToLower() switch
    {
        "id" => track => track.Id,
        "name" => track => track.Name,
        "album" => track => track.Album.Name,
        "author" => track => track.Album.Author.Name,
        _ => track => track.Name
    };

    public QueryHandler(ITrackRepository trackRepository)
    {
        _trackRepository = trackRepository;
    }

    public async Task<Result<IEnumerable<TrackFull>>> Handle(Query request, CancellationToken cancellationToken)
    {
        var tracks = await _trackRepository
            .FilterAsync(ContainsTextInName(request.SearchQuery))
            .Skip(request.PageSize * (request.PageIndex - 1))
            .Take(request.PageSize)
            .OrderBy(Sort(request.SortBy))
            .Select(t => new TrackFull(t))
            .ToListAsync(cancellationToken: cancellationToken);

        return new Result<IEnumerable<TrackFull>>(tracks);
    }
}