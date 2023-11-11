using DatabaseServices.EntityValidators.Interfaces;
using DatabaseServices.Repositories;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace DatabaseServices.CommandHandlers.CreateHandlers;

public interface IAuthorCreateHandler
{
    public Task<AuthorCreationResult> CreateAsync(AuthorCreationData data);
}

public class AuthorCreateHandler : IAuthorCreateHandler
{
    private readonly IAuthorRepository _authorRepository;
    private readonly IAuthorValidator _authorValidator;

    public AuthorCreateHandler(IAuthorValidator authorValidator, IAuthorRepository authorRepository)
    {
        _authorValidator = authorValidator;
        _authorRepository = authorRepository;
    }

    public async Task<AuthorCreationResult> CreateAsync(AuthorCreationData data)
    {
        var validationResult = await _authorValidator.Validate(data);
        var author = validationResult.IsValid ? new Author(data.Name, validationResult.Owner!) : null;
        if (author != null)
            await _authorRepository.AddAsync(author);
        return new AuthorCreationResult((AuthorValidationCode)validationResult.ValidationCode, author);
    }
}