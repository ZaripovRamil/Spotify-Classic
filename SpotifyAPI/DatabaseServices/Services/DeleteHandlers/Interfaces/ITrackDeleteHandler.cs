using Models.DTO.BackToFront.EntityCreationResult;

namespace DatabaseServices.Services.DeleteHandlers.Interfaces;

public interface ITrackDeleteHandler
{
    Task<TrackCreationResult> HandleDeleteById(string id);
}