using Models.DTO.BackToFront.Full;
using Utils.CQRS;

namespace AdminAPI.Features.Albums.GetBy.AuthorName;

public record Query(string? SearchQuery) : IQuery<IEnumerable<AlbumFull>>;