using DatabaseServices.Services.EntityValidators.Interfaces;
using DatabaseServices.Services.Factories.Interfaces;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace DatabaseServices.Services.Factories.Implementations;

public class AuthorFactory : IAuthorFactory
{
    private readonly IAuthorValidator _authorValidator;

    public AuthorFactory(IAuthorValidator authorValidator)
    {
        _authorValidator = authorValidator;
    }

    public async Task<(AuthorValidationCode, Author?)> Create(AuthorCreationData data)
    {
        var validationResult = await _authorValidator.Validate(data);
        return ((AuthorValidationCode)validationResult.ValidationCode,
            validationResult.IsValid ? new Author(data.Name, validationResult.Owner!) : null);
    }
}