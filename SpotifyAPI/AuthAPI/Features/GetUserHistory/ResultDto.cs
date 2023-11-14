using Models.DTO.Light;

namespace AuthAPI.Features.GetUserHistory;

public record ResultDto(List<TrackLight>? History);