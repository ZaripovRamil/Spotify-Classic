using Models.DTO.Light;
using Models.Entities;

namespace Models.DTO.Full;

public class AuthorFull
{
    public string Id { get; set; } = default!;
    public string Name { get; set; } = default!;
    public List<AlbumLight> Albums { get; set; } = default!;

    public AuthorFull()
    {
    }

    public AuthorFull(Author author)
    {
        Id = author.Id;
        Name = author.Name;
        Albums = author.Albums.Select(album => new AlbumLight(album)).ToList();
    }
}