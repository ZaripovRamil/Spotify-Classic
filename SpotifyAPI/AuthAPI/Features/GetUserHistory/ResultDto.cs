using Models.DTO.BackToFront.Light;

namespace AuthAPI.Features.GetUserHistory;

public record ResultDto(List<TrackLight>? History);