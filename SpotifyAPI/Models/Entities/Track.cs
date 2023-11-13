using Microsoft.EntityFrameworkCore;
using Models.Entities.Joints;

namespace Models.Entities;

[PrimaryKey("Id")]
public class Track : Entity
{
    public string FileId { get; set; } = default!;

    public Track(string name, Album album, string fileId)
    {
        Name = name;
        AlbumId = album.Id;
        FileId = fileId;
    }

    public Track(string id, string name, Album album, string fileId) : this(name, album, fileId)
    {
        Id = id;
    }

    public Track(string name, string albumId, string fileId, Genre[] genres)
    {
        Name = name;
        AlbumId = albumId;
        FileId = fileId;
        Genres = genres.ToList();
    }

    public Track(string name, Album album, string fileId, params Genre[] genres) : this(name, album, fileId)
    {
        Genres = genres.ToList();
    }

    public Track()
    {
    }

    public string AlbumId { get; set; } = default!;
    public Album Album { get; set; } = default!;
    public List<Playlist> InPlaylists { get; set; } = new();
    public List<GenreTrack> GenreTracks { get; set; } = new();
    public List<UserTrack> UserTracks { get; set; } = new();
    public List<Genre> Genres { get; set; } = new();
    public List<User> Listeners { get; set; } = new();
}