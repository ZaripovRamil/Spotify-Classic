using Models.DTO.BackToFront.Light;

namespace PlayerAPI.Features.GetTracks;

public record ResultDto(List<TrackLight> Tracks);