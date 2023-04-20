using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace Models.DTO.BackToFront.EntityCreationResult;

public class GenreCreationResult:EntityCreationResult
{
    private static readonly Dictionary<GenreValidationCode, string> Messages = new()
    {
        {GenreValidationCode.Successful, "Success"},
        {GenreValidationCode.AlreadyExists, "This genre already exists"}
    };
    
    public string? GenreId { get; set; }

    public GenreCreationResult(GenreValidationCode code, Genre? genre)
    {
        IsSuccessful = code == GenreValidationCode.Successful;
        ResultMessage = Messages[code];
        GenreId = genre?.Id;
    }

    public GenreCreationResult((GenreValidationCode State, Genre? Genre) data) : this(data.State, data.Genre)
    {
    }
}