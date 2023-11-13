using Models.DTO.BackToFront.Statistics;
using Models.Entities;

namespace AuthAPI.Features.GetStatistics;

public interface IStatisticSnapshotCreator
{
    public Task<StatisticSnapshot> Create(User? user);
}