using Models.DTO.InterServices.EntityValidationCodes;

namespace Models.DTO.InterServices.ValidationResult;

public class GenreValidationResult:EntityValidationResult
{
    public GenreValidationResult(GenreValidationCode code) : base((int)code)
    {
    }
}