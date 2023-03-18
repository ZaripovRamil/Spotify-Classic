using Microsoft.EntityFrameworkCore;

namespace Models;

[PrimaryKey("Id")]
public class Playlist
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; }
    public User Owner { get; set; }
    public PlaylistType Type { get; set; }
    public List<Track> Tracks = new();

    public Playlist(string name, User owner, PlaylistType type)
    {
        Name = name;
        Owner = owner;
        Type = type;
    }

    public Playlist()
    {
    }
}