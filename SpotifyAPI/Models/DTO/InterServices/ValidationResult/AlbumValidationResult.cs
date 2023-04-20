using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace Models.DTO.InterServices.ValidationResult;

public class AlbumValidationResult:EntityValidationResult
{
    public AlbumValidationCode ValidationCode { get; set; }
    public Author Author { get; set; }
}