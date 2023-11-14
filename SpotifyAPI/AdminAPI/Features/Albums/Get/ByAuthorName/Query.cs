using Models.DTO.Full;
using Utils.CQRS;

namespace AdminAPI.Features.Albums.Get.ByAuthorName;

public record Query(string? SearchQuery) : IQuery<IEnumerable<AlbumFull>>;