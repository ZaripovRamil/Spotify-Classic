using Models.DTO.BackToFront.Full;

namespace SearchAPI.Features.SearchTracksByAlbumOrAuthor;

public record ResultDto(IEnumerable<TrackFull> Tracks);