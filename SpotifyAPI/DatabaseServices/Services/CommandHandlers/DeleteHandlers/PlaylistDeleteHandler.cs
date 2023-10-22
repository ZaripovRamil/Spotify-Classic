using DatabaseServices.Services.Repositories.Implementations;
using Models.DTO.BackToFront.EntityDeletionResult;

namespace DatabaseServices.Services.CommandHandlers.DeleteHandlers;

public interface IPlaylistDeleteHandler
{
    Task<PlaylistDeletionResult> Delete(string id);
}

public class PlaylistDeleteHandler : IPlaylistDeleteHandler
{
    private readonly IPlaylistRepository _playlistRepository;

    public PlaylistDeleteHandler(IPlaylistRepository playlistRepository)
    {
        _playlistRepository = playlistRepository;
    }

    public async Task<PlaylistDeletionResult> Delete(string id)
    {
        var playlist = await _playlistRepository.Get(id);
        var result = new PlaylistDeletionResult { IsSuccessful = true, ResultMessage = "Successful" };
        if (playlist is null)
        {
            result.IsSuccessful = false;
            result.ResultMessage = "The requested playlist doesn't exist";

            return result;
        }

        await _playlistRepository.Delete(playlist);

        return result;
    }
}