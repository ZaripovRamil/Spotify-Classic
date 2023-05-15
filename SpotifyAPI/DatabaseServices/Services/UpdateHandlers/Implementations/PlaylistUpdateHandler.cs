using DatabaseServices.Services.Accessors.Interfaces;
using DatabaseServices.Services.UpdateHandlers.Interfaces;
using Models.DTO.BackToFront.EntityUpdateResult;
using Models.DTO.FrontToBack.EntityUpdateData;
using Models.Entities;

namespace DatabaseServices.Services.UpdateHandlers.Implementations;

public class PlaylistUpdateHandler : IPlaylistUpdateHandler
{
    private readonly IDbPlaylistAccessor _playlistAccessor;

    public PlaylistUpdateHandler(IDbPlaylistAccessor playlistAccessor)
    {
        _playlistAccessor = playlistAccessor;
    }

    public async Task<PlaylistUpdateResult> HandleUpdateById(string id, PlaylistUpdateData updateData)
    {
        var playlist = await _playlistAccessor.Get(id);
        var result = new PlaylistUpdateResult { IsSuccessful = true, ResultMessage = "Successful" };
        if (playlist is null)
        {
            result.IsSuccessful = false;
            result.ResultMessage = "The requested playlist doesn't exist";

            return result;
        }

        if (updateData.Id != playlist.Id)
        {
            result.IsSuccessful = false;
            result.ResultMessage = "Unable to update the id field";

            return result;
        }

        await _playlistAccessor.Update(new Playlist(id, updateData.Name, playlist.Owner, updateData.PreviewId));
        return result;
    }
}