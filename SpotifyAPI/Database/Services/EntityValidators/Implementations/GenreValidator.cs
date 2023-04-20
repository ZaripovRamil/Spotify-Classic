using Database.Services.EntityValidators.Interfaces;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.DTO.InterServices.ValidationResult;

namespace Database.Services.EntityValidators.Implementations;

public class GenreValidator:IGenreValidator
{
    public GenreValidationResult Validate(GenreCreationData data)
    {
        throw new NotImplementedException();
    }
}