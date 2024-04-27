using Models.DTO.Auth;
using Models.DTO.Light;
using Utils.CQRS;

namespace AuthAPI.Features.GetUserHistory;

public class QueryHandler : IQueryHandler<Query, HistoryResult>
{
    public Task<Result<HistoryResult>> Handle(Query request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new Result<HistoryResult>(new HistoryResult(request.User?.UserTracks
            .OrderByDescending(ut => ut.ListenTime)
            .Select(ut => ut.Track)
            .Distinct()
            .Take(10)
            .Select(t => new TrackLight(t))
            .ToList())));
    }
}