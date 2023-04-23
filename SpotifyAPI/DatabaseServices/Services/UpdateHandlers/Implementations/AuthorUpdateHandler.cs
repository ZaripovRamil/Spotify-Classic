using DatabaseServices.Services.Accessors.Interfaces;
using DatabaseServices.Services.UpdateHandlers.Interfaces;
using Models.DTO.BackToFront.EntityUpdateResult;
using Models.DTO.FrontToBack.EntityUpdateData;
using Models.Entities;

namespace DatabaseServices.Services.UpdateHandlers.Implementations;

public class AuthorUpdateHandler : IAuthorUpdateHandler
{
    private readonly IDbAuthorAccessor _authorAccessor;

    public AuthorUpdateHandler(IDbAuthorAccessor authorAccessor)
    {
        _authorAccessor = authorAccessor;
    }

    public async Task<AuthorUpdateResult> HandleUpdateById(string id, AuthorUpdateData updateData)
    {
        var author = await _authorAccessor.GetById(id);
        var result = new AuthorUpdateResult { IsSuccessful = true, ResultMessage = "Successful" };
        if (author is null)
        {
            result.IsSuccessful = false;
            result.ResultMessage = "The requested author doesn't exist";

            return result;
        }

        if (updateData.Id != author.Id)
        {
            result.IsSuccessful = false;
            result.ResultMessage = "Unable to update the id field";

            return result;
        }

        // TODO: see comment to DbAuthorAccessor.Update
        await _authorAccessor.Update(new Author(id, author.User, updateData.Name));
        return result;
    }
}