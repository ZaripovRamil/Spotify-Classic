using AuthAPI.Features.GetStatistics.Dto;
using Models.Entities;
using Utils.CQRS;

namespace AuthAPI.Features.GetStatistics;

public record Query(User? User) : IQuery<ResultDto>;