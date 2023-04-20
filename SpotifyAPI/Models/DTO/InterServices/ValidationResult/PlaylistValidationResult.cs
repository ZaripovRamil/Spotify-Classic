using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace Models.DTO.InterServices.ValidationResult;

public class PlaylistValidationResult:EntityValidationResult
{
    public PlaylistValidationCode ValidationCode { get; set; }
    public User Owner { get; set; }
}