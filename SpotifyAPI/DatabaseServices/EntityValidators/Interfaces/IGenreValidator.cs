using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.ValidationResult;

namespace DatabaseServices.EntityValidators.Interfaces;

public interface IGenreValidator
{
    public Task<GenreValidationResult> Validate(GenreCreationData data);
}