using Microsoft.EntityFrameworkCore;

namespace Models.Entities;

[PrimaryKey("Id")]
public class Playlist:Entity
{
    public required string PreviewId { get; set; }
    public required User Owner { get; set; }
    public required List<Track> Tracks { get; set; }

    public Playlist(string name, User owner, string previewId = "default_playlist")
    {
        Name = name;
        Owner = owner;
        PreviewId = previewId;
        Tracks = new List<Track>();
    }

    public Playlist(string id, string name, User owner, string previewId)
    {
        Id = id;
        Name = name;
        Owner = owner;
        PreviewId = previewId;
    }

    public Playlist() { }
}