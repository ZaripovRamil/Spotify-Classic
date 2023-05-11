using Models.Entities;

namespace Models.DTO.BackToFront.Light;

public class GenreLight
{
    public string Id { get; set; }
    public string Name { get; set; }

    public GenreLight() { }

    public GenreLight(Genre genre)
    {
        Id = genre.Id;
        Name = genre.Name;
    }
}