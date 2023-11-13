using Models.Entities;
using Utils.CQRS;

namespace AuthAPI.Features.GetStatistics;

public class QueryHandler : IQueryHandler<Query, ResultDto>
{
    private readonly IStatisticSnapshotCreator _snapshotCreator;

    public QueryHandler(IStatisticSnapshotCreator snapshotCreator)
    {
        _snapshotCreator = snapshotCreator;
    }

    public async Task<Result<ResultDto>> Handle(Query request, CancellationToken cancellationToken)
    {
        if (ValidateSubscription(request.User))
            return new Result<ResultDto>(new ResultDto(await _snapshotCreator.Create(request.User)));
        var res = new Result<ResultDto>(new ResultDto(null));
        res.Fail();
        res.AddErrors("Forbidden");
        return res;
    }

    private static bool ValidateSubscription(User? user)
    {
        return user is { Subscription: not null } && user.SubscriptionExpire > DateTime.Now;
    }
}