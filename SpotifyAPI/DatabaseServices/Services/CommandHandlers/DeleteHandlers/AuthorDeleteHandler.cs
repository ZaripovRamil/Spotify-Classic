using DatabaseServices.Services.Repositories.Implementations;
using Models.DTO.BackToFront.EntityDeletionResult;

namespace DatabaseServices.Services.CommandHandlers.DeleteHandlers;

public interface IAuthorDeleteHandler
{
    Task<AuthorDeletionResult> DeleteAsync(string id);
}

public class AuthorDeleteHandler : IAuthorDeleteHandler
{
    private readonly IAuthorRepository _authorRepository;

    public AuthorDeleteHandler(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }

    public async Task<AuthorDeletionResult> DeleteAsync(string id)
    {
        var author = await _authorRepository.GetByIdAsync(id);
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

        await _authorRepository.DeleteAsync(author);

        return result;
    }
}