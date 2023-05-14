using DatabaseServices.Services.Accessors.Interfaces;
using DatabaseServices.Services.DeleteHandlers.Interfaces;
using Models.DTO.BackToFront.EntityDeletionResult;

namespace DatabaseServices.Services.DeleteHandlers.Implementations;

public class AuthorDeleteHandler : IAuthorDeleteHandler
{
    private readonly IDbAuthorAccessor _authorAccessor;

    public AuthorDeleteHandler(IDbAuthorAccessor authorAccessor)
    {
        _authorAccessor = authorAccessor;
    }

    public async Task<AuthorDeletionResult> HandleDeleteById(string id)
    {
        var author = await _authorAccessor.GetById(id);
        var result = new AuthorDeletionResult { IsSuccessful = true, ResultMessage = "Successful" };
        if (author is null)
        {
            result.IsSuccessful = false;
            result.ResultMessage = "The requested author doesn't exist";

            return result;
        }

        if (author.Albums.Count > 0)
        {
            result.IsSuccessful = false;
            result.ResultMessage =
                "The requested author owns at least one album. It has to own zero for safe delete.";

            return result;
        }

        await _authorAccessor.Delete(author);

        return result;
    }
}