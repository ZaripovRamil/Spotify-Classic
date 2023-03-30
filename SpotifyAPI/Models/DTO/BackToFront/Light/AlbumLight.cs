using Models.Entities;

namespace Models.DTO.BackToFront.Light;

public class AlbumLight
{
    public string Id { get; set; }
    public string Name { get; set; }
    
    public AuthorLight Author { get; set; }

    public AlbumLight(Album album)
    {
        Id = album.Id;
        Name = album.Name;
        Author = new AuthorLight(album.Author);
    }
}