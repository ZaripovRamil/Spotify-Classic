using Microsoft.EntityFrameworkCore;
using Models.Entities.Joints;

namespace Models.Entities;

[PrimaryKey("Id")]
public class Track : Entity
{
    public string FileId { get; set; }

    public Track(string name, Album album, string fileId)
    {
        Name = name;
        // Album = album;
        AlbumId = album.Id;
        FileId = fileId;
    }

    public Track(string id, string name, Album album, string fileId) : this(name, album, fileId)
    {
        Id = id;
    }

    public Track(string name, Album album, string fileId, params Genre[] genres) : this(name, album, fileId)
    {
        Genres = genres.ToList();
    }

    public Track()
    {
    }

    public string AlbumId { get; set; }
    public Album Album { get; set; }
    public List<Playlist> InPlaylists { get; set; }
    public List<GenreTrack> GenreTracks { get; set; } = new();
    public List<UserTrack> UserTracks { get; set; } = new();
    public List<Genre> Genres { get; set; } = new();
    public List<User> Listeners { get; set; }
}