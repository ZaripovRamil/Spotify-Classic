using Models.DTO.BackToFront.EntityDeletionResult;

namespace DatabaseServices.Services.DeleteHandlers.Interfaces;

public interface IAuthorDeleteHandler
{
    Task<AuthorDeletionResult> HandleDeleteById(string id);
}