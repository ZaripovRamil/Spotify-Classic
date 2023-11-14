using DatabaseServices.Repositories;
using Models.DTO.Light;
using Utils.CQRS;

namespace PlayerAPI.Features.GetPlaylists;

public class QueryHandler: IQueryHandler<Query, ResultDto>
{
    private readonly IPlaylistRepository _playlistRepository;

    public QueryHandler(IPlaylistRepository playlistRepository)
    {
        _playlistRepository = playlistRepository;
    }

    public async Task<Result<ResultDto>> Handle(Query request, CancellationToken cancellationToken)
    {
        return new ResultDto(
            await _playlistRepository
                .GetAllAsync()
                .Select(playlist => new PlaylistLight(playlist))
                .ToListAsync(cancellationToken: cancellationToken));
    }
}