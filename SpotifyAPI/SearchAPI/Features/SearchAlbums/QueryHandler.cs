using DatabaseServices.Services.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;
using Models.DTO.BackToFront.Light;
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
            await _albumRepository.GetAll()
                .Where(Spec.NameContains(request.Filter))
                .AsAsyncEnumerable()
                .Select(a => new AlbumLight(a))
                .ToListAsync(cancellationToken: cancellationToken));
    }
}