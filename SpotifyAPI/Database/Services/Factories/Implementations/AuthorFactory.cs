using Database.Services.EntityValidators.Interfaces;
using Database.Services.Factories.Interfaces;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace Database.Services.Factories.Implementations;

public class AuthorFactory : IAuthorFactory
{
    private readonly IAuthorValidator _authorValidator;

    public AuthorFactory(IAuthorValidator authorValidator)
    {
        _authorValidator = authorValidator;
    }

    public async Task<(AuthorValidationCode, Author?)> Create(AuthorCreationData data)
    {
        var validationResult = _authorValidator.Validate(data);
        return (validationResult.ValidationCode,
            validationResult.IsValid ? new Author(data.Name, validationResult.Owner) : null);
    }
}