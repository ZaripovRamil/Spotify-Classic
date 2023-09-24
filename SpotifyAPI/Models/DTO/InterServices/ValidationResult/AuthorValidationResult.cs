using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace Models.DTO.InterServices.ValidationResult;

public class AuthorValidationResult : EntityValidationResult
{
    public AuthorValidationResult(AuthorValidationCode code, User? owner) : base((int)code)
    {
        Owner = owner;
    }

    public User? Owner { get; set; }
}