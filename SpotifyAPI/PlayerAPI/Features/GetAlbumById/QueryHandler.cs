using DatabaseServices.Repositories;
using Models.DTO.Full;
using Utils.Clickhouse;
using Utils.CQRS;
using static Models.ValidationErrors.AlbumErrors;

namespace PlayerAPI.Features.GetAlbumById;

public class QueryHandler : IQueryHandler<Query, AlbumFull>
{
    private readonly IAlbumRepository _albumRepository;
    private readonly IClickHouseService _clickHouseService;

    public QueryHandler(IAlbumRepository albumRepository, IClickHouseService clickHouseService)
    {
        _albumRepository = albumRepository;
        _clickHouseService = clickHouseService;
    }

    public async Task<Result<AlbumFull>> Handle(Query request, CancellationToken cancellationToken)
    {
        var album = await _albumRepository.GetByIdAsync(request.Id);
        if (album is null)
            return new Result<AlbumFull>(AlbumNotFound);
        var albumFull = new AlbumFull(album);
        var trackListens = new Dictionary<string, int>();
        foreach (var trackId in albumFull.Tracks.Select(track => track.Id))
            trackListens.Add(trackId, await _clickHouseService.GetTrackListenCount(trackId));
        albumFull.ListenCounts = trackListens;
        return new Result<AlbumFull>(albumFull);
    }
}