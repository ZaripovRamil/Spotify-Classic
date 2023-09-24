using Models.DTO.BackToFront.Light;
using Models.Entities;

namespace Models.DTO.BackToFront.Full;

public class AlbumFull
{
    public string Id { get; set; } = default!;
    public string PreviewId { get; set; } = default!;
    public string Name { get; set; } = default!;
    public AuthorLight Author { get; set; } = default!;
    public List<TrackLight> Tracks { get; set; } = default!;
    public string Type { get; set; } = default!;

    public AlbumFull()
    {
    }

    public AlbumFull(Album album)
    {
        Id = album.Id;
        Name = album.Name;
        Author = new AuthorLight(album.Author);
        Tracks = album.Tracks.Select(track => new TrackLight(track)).ToList();
        PreviewId = album.PreviewId;
        Type = album.Type.ToString();
    }
}