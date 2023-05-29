using Models.DTO.BackToFront.Light;

namespace Models.DTO.BackToFront;

public class AuthorsSearchResult
{
    public AuthorsSearchResult(List<AuthorLight> authors)
    {
        Authors = authors;
    }
    
    public List<AuthorLight> Authors { get; set; }
}