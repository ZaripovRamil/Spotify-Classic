using Models.Entities;

namespace Models.DTO.BackToFront.EntityCreationResult;

public class AlbumCreationResult
{
    private static readonly Dictionary<AlbumCreationCode, string> Messages = new()
    {
        {AlbumCreationCode.Successful, "Success"},
        {AlbumCreationCode.InvalidAuthor, "Invalid AuthorId"},
        {AlbumCreationCode.UnknownError, "Unknown error"}
    };

    public bool IsSuccessful { get; set; }
    public string? AlbumId { get; set; }
    public string ResultMessage { get; set; }

    public AlbumCreationResult(AlbumCreationCode code, Album? album)
    {
        IsSuccessful = code == AlbumCreationCode.Successful;
        ResultMessage = Messages[code];
        AlbumId = album?.Id;
    }

    public AlbumCreationResult((AlbumCreationCode State, Album? Album) data) : this(data.State, data.Album) { }
}