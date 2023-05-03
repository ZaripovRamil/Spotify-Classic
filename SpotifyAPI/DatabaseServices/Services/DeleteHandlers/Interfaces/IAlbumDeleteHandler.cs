using Models.DTO.BackToFront.EntityDeletionResult;

namespace DatabaseServices.Services.DeleteHandlers.Interfaces;

public interface IAlbumDeleteHandler
{
    Task<AlbumDeletionResult> HandleDeleteById(string id);
}