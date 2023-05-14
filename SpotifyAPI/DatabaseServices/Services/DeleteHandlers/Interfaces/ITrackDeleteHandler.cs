using Models.DTO.BackToFront.EntityDeletionResult;

namespace DatabaseServices.Services.DeleteHandlers.Interfaces;

public interface ITrackDeleteHandler
{
    Task<TrackDeletionResult> HandleDeleteById(string id);
}