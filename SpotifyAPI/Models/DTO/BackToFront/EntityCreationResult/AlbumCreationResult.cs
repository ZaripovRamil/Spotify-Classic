using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace Models.DTO.BackToFront.EntityCreationResult;

public class AlbumCreationResult:EntityCreationResult
{
    private static readonly Dictionary<AlbumValidationCode, string> Messages = new()
    {
        {AlbumValidationCode.Successful, "Success"},
        {AlbumValidationCode.InvalidAuthor, "Invalid AuthorId"},
        {AlbumValidationCode.UnknownError, "Unknown error"}
    };
    
    public string? AlbumId { get; set; }

    public AlbumCreationResult(AlbumValidationCode code, Album? album)
    {
        IsSuccessful = code == AlbumValidationCode.Successful;
        ResultMessage = Messages[code];
        AlbumId = album?.Id;
    }

    public AlbumCreationResult((AlbumValidationCode State, Album? Album) data) : this(data.State, data.Album)
    {
    }
}