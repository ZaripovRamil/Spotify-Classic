using DatabaseServices.Services.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;
using Models.DTO.BackToFront.Full;
using Utils.CQRS;

namespace SearchAPI.Features.SearchTracksByAlbumOrAuthor;

public class QueryHandler : IQueryHandler<Query, ResultDto>
{
    private readonly ITrackRepository _trackRepository;

    public QueryHandler(ITrackRepository trackRepository)
    {
        _trackRepository = trackRepository;
    }

    public async Task<Result<ResultDto>> Handle(Query request, CancellationToken cancellationToken)
    {
        return new ResultDto(
            await _trackRepository.GetAll()
                .Where(Spec.AlbumNameContains(request.Filter) || Spec.AuthorNameContains(request.Filter))
                .AsAsyncEnumerable()
                .Select(t => new TrackFull(t))
                .ToListAsync(cancellationToken: cancellationToken));
    }
}