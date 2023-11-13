using Models.DTO.BackToFront.Statistics;

namespace AuthAPI.Features.GetStatistics;

public record ResultDto(StatisticSnapshot? Snapshot);