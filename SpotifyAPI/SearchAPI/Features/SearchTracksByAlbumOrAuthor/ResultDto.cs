using Models.DTO.Full;

namespace SearchAPI.Features.SearchTracksByAlbumOrAuthor;

public record ResultDto(IEnumerable<TrackFull> Tracks);