using Models.Entities;

namespace Models.DTO.BackToFront.Light;

public class AuthorLight
{
    public string Id { get; set; }
    public string Name { get; set; }

    public AuthorLight()
    {
    }

    public AuthorLight(Author author)
    {
        Id = author.Id;
        Name = author.Name;
    }
}