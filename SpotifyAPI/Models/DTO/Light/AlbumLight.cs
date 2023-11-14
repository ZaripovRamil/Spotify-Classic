using Models.DTO.Full;
using Models.Entities;

namespace Models.DTO.Light;

public class AlbumLight
{
    public string Id { get; set; } = default!;
    public string PreviewId { get; set; } = default!;
    public string Name { get; set; } = default!;
    public AuthorLight Author { get; set; } = default!;

    public AlbumLight()
    {
    }

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