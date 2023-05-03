using Models.DTO.BackToFront.Light;
using Models.Entities;

namespace Models.DTO.BackToFront.Full;

public class AlbumFull
{
    public string Id { get; set; }
    public string PreviewId { get; set; }
    public string Name { get; set; }
    public AuthorLight Author { get; set; }
    public List<TrackLight> Tracks { get; set; }

    public AlbumFull() { }

    public AlbumFull(Album album)
    {
        Id = album.Id;
        Name = album.Name;
        Author = new AuthorLight(album.Author);
        Tracks = album.Tracks.Select(track => new TrackLight(track)).ToList();
        PreviewId = album.PreviewId;
    }
}