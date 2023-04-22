using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace Models.DTO.BackToFront.EntityCreationResult;

public class AuthorCreationResult:EntityCreationResult
{
    private static readonly Dictionary<AuthorValidationCode, string> Messages = new()
    {
        {AuthorValidationCode.Successful, "Success"},
        {AuthorValidationCode.InvalidUser, "Invalid UserId"},
        {AuthorValidationCode.UnknownError, "Unknown error"}
    };
    
    public string? AuthorId { get; set; }
    public AuthorCreationResult(AuthorValidationCode code, Author? author)
    {
        IsSuccessful = code == AuthorValidationCode.Successful;
        ResultMessage = Messages[code];
        AuthorId = author?.Id;
    }

    public AuthorCreationResult((AuthorValidationCode State, Author? Author) data) : this(data.State, data.Author)
    {
    }
    public AuthorCreationResult() { }
}