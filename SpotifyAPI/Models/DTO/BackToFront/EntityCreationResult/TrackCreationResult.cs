using Models.Entities;

namespace Models.DTO.BackToFront.EntityCreationResult;

public class TrackCreationResult
{
    private static readonly Dictionary<TrackCreationCode, string> Messages = new() {
        {TrackCreationCode.Successful, "Success"},
        {TrackCreationCode.InvalidAlbum, "Invalid AlbumId"}};
    public bool IsSuccessful { get; set; }
    public string? TrackId { get; set; }
    public string ResultMessage { get; set; }

    public TrackCreationResult(TrackCreationCode code, Track? track)
    {
        IsSuccessful = code == TrackCreationCode.Successful;
        ResultMessage = Messages[code];
        TrackId = track?.Id;
    }
}