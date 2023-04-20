using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.ValidationResult;

namespace Database.Services.EntityValidators.Interfaces;

public interface IGenreValidator
{
    public GenreValidationResult Validate(GenreCreationData data);
}