using Models.DTO.BackToFront.Light;
using Utils.CQRS;

namespace AuthAPI.Features.GetUserHistory;

public class QueryHandler : IQueryHandler<Query, ResultDto>
{
    public Task<Result<ResultDto>> Handle(Query request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new Result<ResultDto>(new ResultDto(request.User?.UserTracks
            .OrderByDescending(ut => ut.ListenTime)
            .Select(ut => ut.Track)
            .Distinct()
            .Take(10)
            .Select(t => new TrackLight(t))
            .ToList())));
    }
}