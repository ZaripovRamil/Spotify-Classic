using Models.DTO.Full;
using Utils.CQRS;

namespace AdminAPI.Features.Tracks.Get.ByFilters;

public record Query(
    int PageSize,
    int PageIndex,
    string? SortBy,
    string? SearchQuery) : IQuery<IEnumerable<TrackFull>>;