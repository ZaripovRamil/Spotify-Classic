using Models.DTO.BackToFront.Full;
using Utils.CQRS;

namespace AdminAPI.Features.Albums.GetByFilters;

public record Query(
    string? AlbumType,
    int? TracksMin,
    int? TracksMax,
    int? MaxCount,
    string? SortBy,
    string? Search): IQuery<IEnumerable<AlbumFull>>;