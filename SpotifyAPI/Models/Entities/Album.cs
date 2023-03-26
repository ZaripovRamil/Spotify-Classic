using Models.Entities;

namespace Models;

public class Album
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; }
    public Author Author { get; set; }
    public int ReleaseYear { get; set; }
    public AlbumType Type { get; set; }
    public List<Track> Tracks { get; set; }
}