using DatabaseServices.Repositories;
using Models.DTO.BackToFront.Full;
using Utils.CQRS;
using static Models.Entities.ValidationErrors.TrackErrors;

namespace AdminAPI.Features.Tracks.Get.ById;

public class QueryHandler : IQueryHandler<Query, TrackFull>
{
    private readonly ITrackRepository _trackRepository;

    public QueryHandler(ITrackRepository trackRepository)
    {
        _trackRepository = trackRepository;
    }

    public async Task<Result<TrackFull>> Handle(Query request, CancellationToken cancellationToken)
    {
        var track = await _trackRepository.GetByIdAsync(request.Id);
        return track is null ?
            new Result<TrackFull>(TrackNotFound) :
            new Result<TrackFull>(new TrackFull(track));
    }
}