using Models.DTO.BackToFront.Full;
using Utils.CQRS;

namespace AdminAPI.Features.Tracks.Get.ByAlbumAuthor;

public record Query(string? SearchQuery) : IQuery<IEnumerable<TrackFull>>;