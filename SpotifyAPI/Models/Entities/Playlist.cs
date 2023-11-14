using Microsoft.EntityFrameworkCore;

namespace Models.Entities;

[PrimaryKey("Id")]
public class Playlist : Entity
{
    public string PreviewId { get; set; } = default!;
    public User Owner { get; set; } = default!;
    public string OwnerId { get; set; } = default!;
    public List<Track> Tracks { get; set; } = new();

    public Playlist(string name, User owner, string previewId = "default_playlist")
    {
        Name = name;
        Owner = owner;
        PreviewId = previewId;
        Tracks = new List<Track>();
    }

    public Playlist(string name, string ownerId, string previewId = "default_playlist")
    {
        Name = name;
        OwnerId = ownerId;
        PreviewId = previewId;
    }

    public Playlist(string id, string name, User owner, string previewId)
    {
        Id = id;
        Name = name;
        Owner = owner;
        PreviewId = previewId;
    }

    public Playlist()
    {
    }
}