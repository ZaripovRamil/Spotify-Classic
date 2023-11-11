using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.ValidationResult;

namespace DatabaseServices.EntityValidators.Interfaces;

public interface IAuthorValidator
{
    public Task<AuthorValidationResult> Validate(AuthorCreationData data);
}