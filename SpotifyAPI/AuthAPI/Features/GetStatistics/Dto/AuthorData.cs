using Models.DTO.Light;

namespace AuthAPI.Features.GetStatistics.Dto;

public class AuthorData
{
    public AuthorData(AuthorLight author, int count)
    {
        Author = author;
        Count = count;
    }

    public AuthorLight Author { get; set; }
    public int Count { get; set; }
}