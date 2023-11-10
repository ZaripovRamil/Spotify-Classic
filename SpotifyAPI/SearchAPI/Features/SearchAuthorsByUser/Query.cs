using Utils.CQRS;

namespace SearchAPI.Features.SearchAuthorsByUser;

public record Query(string Filter) : IQuery<ResultDto>;