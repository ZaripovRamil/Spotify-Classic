using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace Models.DTO.InterServices.ValidationResult;

public class TrackValidationResult : EntityValidationResult
{
    public TrackValidationCode ValidationCode { get; set; }
    public Album Album { get; set; }
    public Genre[] Genres { get; set; }
}