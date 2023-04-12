using Microsoft.EntityFrameworkCore;

namespace Models.Entities;

[PrimaryKey("Id")]
public class Playlist
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string PreviewId { get; set; }
    public string Name { get; set; }
    public User Owner { get; set; }
    public List<Track> Tracks { get; set; }

    public Playlist(string name, User owner, string previewId = "default_playlist")
    {
        Name = name;
        Owner = owner;
        PreviewId = previewId;
        Tracks = new List<Track>();
    }

    public Playlist()
    {
    }
}