using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace Models.DTO.InterServices.ValidationResult;

public class TrackValidationResult : EntityValidationResult
{
    public TrackValidationResult(TrackValidationCode code, Album album, Genre[] genres) : base((int)code)
    {
        Album = album;
        Genres = genres;
    }
    public Album Album { get; set; }
    public Genre[] Genres { get; set; }
}