using Models.DTO.BackToFront.Full;
using Utils.CQRS;

namespace AdminAPI.Features.Albums.GetByAuthorName;

public record Query(string? SearchQuery) : IQuery<IEnumerable<AlbumFull>>;