using Models.DTO.Full;
using Utils.CQRS;

namespace AdminAPI.Features.Albums.Get.ByFilters;

public record Query(
    string? AlbumType,
    int? TracksMin,
    int? TracksMax,
    int? MaxCount,
    string? SortBy,
    string? Search): IQuery<IEnumerable<AlbumFull>>;