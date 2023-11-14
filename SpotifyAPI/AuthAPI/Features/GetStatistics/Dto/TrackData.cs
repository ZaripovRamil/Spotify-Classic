using Models.DTO.Light;

namespace AuthAPI.Features.GetStatistics.Dto;

public record TrackData(TrackLight Track, int Count);