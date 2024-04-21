using DatabaseServices.Repositories;
using UserAPI.Dto;
using Utils.CQRS;
using static Models.ValidationErrors.CommonConstants;

namespace UserAPI.Features.Playlists.Delete;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly IPlaylistRepository _playlistRepository;

    public CommandHandler(IPlaylistRepository playlistRepository)
    {
        _playlistRepository = playlistRepository;
    }

    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        var playlist = await _playlistRepository.GetByIdAsync(request.Id);
        await _playlistRepository.DeleteAsync(playlist!);
        return new ResultDto(true, Successful);
    }
}