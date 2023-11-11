using DatabaseServices.Repositories;
using Models.DTO.BackToFront.EntityUpdateResult;
using Models.DTO.FrontToBack.EntityUpdateData;
using Models.Entities;

namespace DatabaseServices.CommandHandlers.UpdateHandlers;

public interface IPlaylistUpdateHandler
{
    Task<PlaylistUpdateResult> Update(string id, PlaylistUpdateData updateData);
}

public class PlaylistUpdateHandler : IPlaylistUpdateHandler
{
    private readonly IPlaylistRepository _playlistRepository;

    public PlaylistUpdateHandler(IPlaylistRepository playlistRepository)
    {
        _playlistRepository = playlistRepository;
    }

    public async Task<PlaylistUpdateResult> Update(string id, PlaylistUpdateData updateData)
    {
        var playlist = await _playlistRepository.GetByIdAsync(id);
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

        await _playlistRepository.UpdateAsync(new Playlist(id, updateData.Name, playlist.Owner, updateData.PreviewId));
        return result;
    }
}