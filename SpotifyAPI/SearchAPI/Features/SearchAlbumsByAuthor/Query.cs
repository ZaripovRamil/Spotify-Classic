using Utils.CQRS;

namespace SearchAPI.Features.SearchAlbumsByAuthor;

public record Query(string Filter) : IQuery<ResultDto>;