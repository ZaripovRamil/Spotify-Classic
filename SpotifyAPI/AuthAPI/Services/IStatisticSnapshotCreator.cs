using Models.DTO.BackToFront.Statistics;
using Models.Entities;

namespace AuthAPI.Services;

public interface IStatisticSnapshotCreator
{
    public Task<StatisticSnapshot> Create(User? user);
}