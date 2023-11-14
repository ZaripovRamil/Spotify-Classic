using Models.DTO.Light;

namespace PlayerAPI.Features.GetTracks;

public record ResultDto(List<TrackLight> Tracks);