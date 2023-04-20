using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace Models.DTO.InterServices.ValidationResult;

public class AuthorValidationResult:EntityValidationResult
{
    public AuthorValidationCode ValidationCode { get; set; }
    public User Owner { get; set; }
}