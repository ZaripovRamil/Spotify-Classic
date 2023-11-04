using Utils.CQRS;

namespace SearchAPI.Features.SearchTracksByAlbumOrAuthor;

public record Query(string Filter) : IQuery<ResultDto>;