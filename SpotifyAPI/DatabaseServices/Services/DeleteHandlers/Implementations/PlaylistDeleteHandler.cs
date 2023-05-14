using DatabaseServices.Services.Accessors.Interfaces;
using DatabaseServices.Services.DeleteHandlers.Interfaces;
using Models.DTO.BackToFront.EntityDeletionResult;

namespace DatabaseServices.Services.DeleteHandlers.Implementations;

public class PlaylistDeleteHandler : IPlaylistDeleteHandler
{
    private readonly IDbPlaylistAccessor _playlistAccessor;

    public PlaylistDeleteHandler(IDbPlaylistAccessor playlistAccessor)
    {
        _playlistAccessor = playlistAccessor;
    }

    public async Task<PlaylistDeletionResult> HandleDeleteById(string id)
    {
        var playlist = await _playlistAccessor.Get(id);
        var result = new PlaylistDeletionResult { IsSuccessful = true, ResultMessage = "Successful" };
        if (playlist is null)
        {
            result.IsSuccessful = false;
            result.ResultMessage = "The requested playlist doesn't exist";

            return result;
        }

        await _playlistAccessor.Delete(playlist);
        
        return result;
    }
}