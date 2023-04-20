using Models.DTO.InterServices.EntityValidationCodes;

namespace Models.DTO.InterServices.ValidationResult;

public class EntityValidationResult
{
    public EntityValidationResult(int validationCode)
    {
        ValidationCode = validationCode;
        IsValid = ValidationCode == (int) EntityValidationCode.Successful;
    }

    public bool IsValid { get; set; }
    public int ValidationCode { get; set; }
}