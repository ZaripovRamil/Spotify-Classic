using Utils.CQRS;

namespace SearchAPI.Features.SearchAlbums;

public record Query(string Filter) : IQuery<ResultDto>;