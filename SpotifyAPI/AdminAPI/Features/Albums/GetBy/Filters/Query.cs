using Models.DTO.BackToFront.Full;
using Utils.CQRS;

namespace AdminAPI.Features.Albums.GetBy.Filters;

public record Query(
    string? AlbumType,
    int? TracksMin,
    int? TracksMax,
    int? MaxCount,
    string? SortBy,
    string? Search): IQuery<IEnumerable<AlbumFull>>;