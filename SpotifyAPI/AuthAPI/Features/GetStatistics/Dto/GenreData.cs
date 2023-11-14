using Models.DTO.Light;

namespace AuthAPI.Features.GetStatistics.Dto;

public record GenreData(GenreLight Genre, int Count);