using DatabaseServices.Services.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;
using Models.DTO.BackToFront.Full;
using Utils.CQRS;

namespace SearchAPI.Features.SearchAlbumsByAuthor;

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
                .Where(Spec.AuthorNameContains(request.Filter))
                .AsAsyncEnumerable()
                .Select(a => new AlbumFull(a))
                .ToListAsync(cancellationToken: cancellationToken));
    }
}