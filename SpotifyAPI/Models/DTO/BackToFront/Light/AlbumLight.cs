using Models.DTO.BackToFront.Full;
using Models.Entities;

namespace Models.DTO.BackToFront.Light;

public class AlbumLight
{
    public string Id { get; set; }
    public string PreviewId { get; set; }
    public string Name { get; set; }
    public AuthorLight Author { get; set; }

    public AlbumLight() { }

    public AlbumLight(Album album)
    {
        Id = album.Id;
        Name = album.Name;
        Author = new AuthorLight(album.Author);
        PreviewId = album.PreviewId;
    }

    public AlbumLight(AlbumFull album)
    {
        Id = album.Id;
        Name = album.Name;
        Author = album.Author;
        PreviewId = album.PreviewId;
    }
}