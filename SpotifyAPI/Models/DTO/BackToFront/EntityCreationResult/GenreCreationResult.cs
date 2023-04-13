using Models.Entities;

namespace Models.DTO.BackToFront.EntityCreationResult;

public class GenreCreationResult
{
    private static readonly Dictionary<GenreCreationCode, string> Messages = new() {
        {GenreCreationCode.Successful, "Success"},
        {GenreCreationCode.AlreadyExists, "This genre already exists"}};
    public bool IsSuccessful { get; set; }
    public string? GenreId { get; set; }
    public string ResultMessage { get; set; }

    public GenreCreationResult(GenreCreationCode code, Genre? genre)
    {
        IsSuccessful = code == GenreCreationCode.Successful;
        ResultMessage = Messages[code];
        GenreId = genre?.Id;
    }

    public GenreCreationResult((GenreCreationCode State, Genre? Genre) data):this(data.State,data.Genre)
    {
    }
}