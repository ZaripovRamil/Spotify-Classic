using DatabaseServices.Repositories;
using Models.DTO.BackToFront.Light;
using Utils.CQRS;

namespace PlayerAPI.Features.GetTracks;

public class QueryHandler: IQueryHandler<Query, ResultDto>
{
    private readonly ITrackRepository _trackRepository;

    public QueryHandler(ITrackRepository trackRepository)
    {
        _trackRepository = trackRepository;
    }

    public async Task<Result<ResultDto>> Handle(Query request, CancellationToken cancellationToken)
    {
        return new ResultDto(
            await _trackRepository
                .GetAllAsync()
                .Select(playlist => new TrackLight(playlist))
                .ToListAsync(cancellationToken: cancellationToken));
    }
}