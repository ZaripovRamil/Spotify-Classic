using Models.DTO.BackToFront.EntityDeletionResult;

namespace DatabaseServices.Services.DeleteHandlers.Interfaces;

public interface IPlaylistDeleteHandler
{
    Task<PlaylistDeletionResult> HandleDeleteById(string id);
}