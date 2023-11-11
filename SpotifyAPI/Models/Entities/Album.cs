using Microsoft.EntityFrameworkCore;
using Models.Entities.Enums;

namespace Models.Entities;

[PrimaryKey("Id")]
public class Album : Entity
{
    public string PreviewId { get; set; } = default!;
    public string AuthorId { get; set; } = default!;
    public Author Author { get; set; } = default!;
    public int ReleaseYear { get; set; }
    public AlbumType Type { get; set; }
    public List<Track> Tracks { get; } = new();

    public Album(string id, string name, Author author, AlbumType albumType, int releaseYear, string previewId) : this(
        name,
        author, albumType, releaseYear, previewId)
    {
        Id = id;
    }

    public Album(string name, Author author, AlbumType albumType, int releaseYear, string previewId) : this(name,
        author, albumType, previewId)
    {
        ReleaseYear = releaseYear;
    }

    public Album(string name, string authorId, AlbumType albumType, int releaseYear, string previewId)
    {
        Name = name;
        AuthorId = authorId;
        Type = albumType;
        ReleaseYear = releaseYear;
        PreviewId = previewId;
    }

    public Album(string name, Author author, AlbumType albumType, string previewId)
    {
        Name = name;
        AuthorId = author.Id;
        Type = albumType;
        ReleaseYear = DateTime.Now.Year;
        PreviewId = previewId;
    }

    public Album()
    {
    }

    public void AddTracks(params Track[] tracks) => Tracks.AddRange(tracks);
}