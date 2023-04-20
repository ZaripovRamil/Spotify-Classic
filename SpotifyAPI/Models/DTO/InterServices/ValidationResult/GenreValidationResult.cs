using Models.DTO.InterServices.EntityValidationCodes;

namespace Models.DTO.InterServices.ValidationResult;

public class GenreValidationResult:EntityValidationResult
{
    public GenreValidationCode ValidationCode{ get; set; }
}