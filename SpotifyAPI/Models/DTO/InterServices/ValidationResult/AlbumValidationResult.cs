using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace Models.DTO.InterServices.ValidationResult;

public class AlbumValidationResult : EntityValidationResult
{
    public AlbumValidationResult(AlbumValidationCode code, Author? author) : base((int)code)
    {
        Author = author;
    }

    public Author? Author { get; set; }
}