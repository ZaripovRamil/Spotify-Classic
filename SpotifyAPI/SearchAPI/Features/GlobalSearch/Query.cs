using Models.DTO.Search;
using Utils.CQRS;

namespace SearchAPI.Features.GlobalSearch;

public record Query(string Filter) : IQuery<SearchResult>;