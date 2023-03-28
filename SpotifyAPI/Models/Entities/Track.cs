using Microsoft.EntityFrameworkCore;

namespace Models.Entities;

[PrimaryKey("Id")]
public class Track
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public Track(string name, Album album, List<Genre> genres)
    {
        Name = name;
        Album = album;
        Genres = genres;
    }

    public Track()
    {
    }

    public string Name { get; set; }
    public Album Album { get; set; }
    public List<Playlist> InPlaylists { get; set; }
    public List<Genre> Genres { get; set; }
    public List<User> History { get; set; }
}