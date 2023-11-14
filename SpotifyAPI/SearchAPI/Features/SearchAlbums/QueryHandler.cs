using DatabaseServices.Repositories;
using Models.DTO.Light;
using Utils.CQRS;

namespace SearchAPI.Features.SearchAlbums;

public class QueryHandler : IQueryHandler<Query, ResultDto>
{
    private readonly IAlbumRepository _albumRepository;

    public QueryHandler(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    public async Task<Result<ResultDto>> Handle(Query request, CancellationToken cancellationToken)
    {
        return new ResultDto(
            await _albumRepository
                .FilterAsync(Spec.NameContains(request.Filter))
                .Select(a => new AlbumLight(a))
                .ToListAsync(cancellationToken: cancellationToken));
    }
}