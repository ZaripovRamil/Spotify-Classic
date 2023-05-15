using Models.DTO.BackToFront.EntityUpdateResult;
using Models.DTO.FrontToBack.EntityUpdateData;

namespace DatabaseServices.Services.UpdateHandlers.Interfaces;

public interface IPlaylistUpdateHandler
{
    Task<PlaylistUpdateResult> HandleUpdateById(string id, PlaylistUpdateData playlistUpdateData);
}