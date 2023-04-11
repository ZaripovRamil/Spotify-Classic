using Microsoft.EntityFrameworkCore;

namespace Models.Entities;

[PrimaryKey("Id")]
public class Track
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string FileId { get; set; }

    public Track(string name, Album album, string fileId)
    {
        Name = name;
        // Album = album;
        AlbumId = album.Id;
        FileId = fileId;
        Genres = new List<Genre>();
    }

    public Track(string name, Album album, List<Genre> genres, string fileId) : this(name, album, fileId)
    {
        Genres = genres;
    }

    public Track() { }

    public string Name { get; set; }
    public string AlbumId { get; set; }
    public Album Album { get; set; }
    public List<Playlist> InPlaylists { get; set; }
    public List<Genre> Genres { get; set; }
    public List<User> History { get; set; }
}