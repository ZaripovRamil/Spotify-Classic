using Models.DTO.BackToFront.EntityUpdateResult;
using Models.DTO.FrontToBack.EntityUpdateData;

namespace DatabaseServices.Services.UpdateHandlers.Interfaces;

public interface ITrackUpdateHandler
{
    Task<TrackUpdateResult> HandleUpdateById(string id, TrackUpdateData updateData);
}