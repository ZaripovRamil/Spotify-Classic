using DatabaseServices.Repositories;
using Models.DTO.BackToFront.EntityUpdateResult;
using Models.DTO.FrontToBack.EntityUpdateData;
using Models.Entities;

namespace DatabaseServices.CommandHandlers.UpdateHandlers;

public interface IAuthorUpdateHandler
{
    Task<AuthorUpdateResult> UpdateAsync(string id, AuthorUpdateData updateData);
}

public class AuthorUpdateHandler : IAuthorUpdateHandler
{
    private readonly IAuthorRepository _authorRepository;

    public AuthorUpdateHandler(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }

    public async Task<AuthorUpdateResult> UpdateAsync(string id, AuthorUpdateData updateData)
    {
        var author = await _authorRepository.GetByIdAsync(id);
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

        // see comment to DbAuthorAccessor.UpdateAsync
        await _authorRepository.UpdateAsync(new Author(id, author.User, updateData.Name));
        return result;
    }
}