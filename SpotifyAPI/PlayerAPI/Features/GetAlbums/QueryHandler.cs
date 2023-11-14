using DatabaseServices.Repositories;
using Models.DTO.Light;
using Utils.CQRS;

namespace PlayerAPI.Features.GetAlbums;

public class QueryHandler: IQueryHandler<Query, ResultDto>
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
                .GetAllAsync()
                .Select(a => new AlbumLight(a))
                .ToListAsync(cancellationToken: cancellationToken));
    }
}