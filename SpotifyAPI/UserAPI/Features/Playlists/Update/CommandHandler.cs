using DatabaseServices.Repositories;
using UserAPI.Dto;
using Utils.CQRS;

namespace UserAPI.Features.Playlists.Update;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly IPlaylistRepository _playlistRepository;

    public CommandHandler(IPlaylistRepository playlistRepository)
    {
        _playlistRepository = playlistRepository;
    }

    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        var playlist = await _playlistRepository.GetByIdAsync(request.PlaylistId);
        playlist!.Name = request.Name;
        playlist.PreviewId = request.PreviewId;
        await _playlistRepository.UpdateAsync(playlist);
        return new ResultDto(true, "Successful");
    }
}