using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace Models.DTO.BackToFront.EntityCreationResult;

public class PlaylistCreationResult:EntityCreationResult
{
    private static readonly Dictionary<PlaylistValidationCode, string> Messages = new()
    {
        {PlaylistValidationCode.Successful, "Success"},
        {PlaylistValidationCode.InvalidUser, "Invalid UserId"},
        {PlaylistValidationCode.UnknownError, "Unknown error"}
    };
    
    public string? PlaylistId { get; set; }

    public PlaylistCreationResult(PlaylistValidationCode code, Playlist? playlist)
    {
        IsSuccessful = code == PlaylistValidationCode.Successful;
        ResultMessage = Messages[code];
        PlaylistId = playlist?.Id;
    }

    public PlaylistCreationResult((PlaylistValidationCode State, Playlist? Playlist) data) : this(data.State,
        data.Playlist)
    {
    }
}