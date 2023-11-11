using DatabaseServices.Repositories;
using Models.DTO.BackToFront.EntityDeletionResult;

namespace DatabaseServices.CommandHandlers.DeleteHandlers;

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
        var playlist = await _playlistRepository.GetByIdAsync(id);
        var result = new PlaylistDeletionResult { IsSuccessful = true, ResultMessage = "Successful" };
        if (playlist is null)
        {
            result.IsSuccessful = false;
            result.ResultMessage = "The requested playlist doesn't exist";

            return result;
        }

        await _playlistRepository.DeleteAsync(playlist);

        return result;
    }
}