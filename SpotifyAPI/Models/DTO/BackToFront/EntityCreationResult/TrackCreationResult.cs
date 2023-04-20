using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace Models.DTO.BackToFront.EntityCreationResult;

public class TrackCreationResult:EntityCreationResult
{
    private static readonly Dictionary<TrackValidationCode, string> Messages = new()
    {
        {TrackValidationCode.Successful, "Success"},
        {TrackValidationCode.InvalidAlbum, "Invalid AlbumId"},
        {TrackValidationCode.UnknownError, "Unknown error"}
    };
    
    public string? TrackId { get; set; }

    public TrackCreationResult(TrackValidationCode code, Track? track)
    {
        IsSuccessful = code == TrackValidationCode.Successful;
        ResultMessage = Messages[code];
        TrackId = track?.Id;
    }

    public TrackCreationResult((TrackValidationCode State, Track? Track) data) : this(data.State, data.Track)
    {
    }
}