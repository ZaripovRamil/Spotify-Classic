using Models.DTO.BackToFront.EntityUpdateResult;
using Models.DTO.FrontToBack.EntityUpdateData;

namespace DatabaseServices.Services.UpdateHandlers.Interfaces;

public interface IAuthorUpdateHandler
{
    Task<AuthorUpdateResult> HandleUpdateById(string id, AuthorUpdateData updateData);
}