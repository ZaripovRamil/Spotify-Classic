using Models.DTO.BackToFront.Light;

namespace Models.DTO.BackToFront.Statistics;

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