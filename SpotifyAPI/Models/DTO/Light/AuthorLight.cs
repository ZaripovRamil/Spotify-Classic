using Models.Entities;

namespace Models.DTO.Light;

public class AuthorLight
{
    public string Id { get; set; } = default!;
    public string Name { get; set; } = default!;

    public AuthorLight()
    {
    }

    public AuthorLight(Author author)
    {
        Id = author.Id;
        Name = author.Name;
    }
}