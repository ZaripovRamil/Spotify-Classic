using Models.Entities;

namespace Models.DTO.BackToFront.EntityCreationResult;

public class PlaylistCreationResult
{
    private static readonly Dictionary<PlaylistCreationCode, string> Messages = new() {
        {PlaylistCreationCode.Successful, "Success"},
        {PlaylistCreationCode.InvalidUser, "Invalid UserId"}};
    public bool IsSuccessful { get; set; }
    public string? PlaylistId { get; set; }
    public string ResultMessage { get; set; }

    public PlaylistCreationResult(PlaylistCreationCode code, Playlist? playlist)
    {
        IsSuccessful = code == PlaylistCreationCode.Successful;
        ResultMessage = Messages[code];
        PlaylistId = playlist?.Id;
    }
}