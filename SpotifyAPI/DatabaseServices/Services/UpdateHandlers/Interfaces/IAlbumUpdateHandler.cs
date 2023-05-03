using Models.DTO.BackToFront.EntityUpdateResult;
using Models.DTO.FrontToBack.EntityUpdateData;

namespace DatabaseServices.Services.UpdateHandlers.Interfaces;

public interface IAlbumUpdateHandler
{
    Task<AlbumUpdateResult> HandleUpdateById(string id, AlbumUpdateData updateData);
}