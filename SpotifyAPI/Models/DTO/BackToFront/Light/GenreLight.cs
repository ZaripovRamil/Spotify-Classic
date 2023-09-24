using Models.Entities;

namespace Models.DTO.BackToFront.Light;

public class GenreLight
{
    public string Id { get; set; } = default!;
    public string Name { get; set; } = default!;

    public GenreLight()
    {
    }

    public GenreLight(Genre genre)
    {
        Id = genre.Id;
        Name = genre.Name;
    }
}