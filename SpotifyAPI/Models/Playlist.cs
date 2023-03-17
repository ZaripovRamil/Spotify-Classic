using Microsoft.EntityFrameworkCore;
using Models.DTO;

namespace Models;

[PrimaryKey("Id")]
public class Playlist
{
    public string Id = Guid.NewGuid().ToString();
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