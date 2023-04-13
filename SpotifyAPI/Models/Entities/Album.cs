using Microsoft.EntityFrameworkCore;
using Models.Entities.Enums;

namespace Models.Entities;

[PrimaryKey("Id")]
public class Album
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string PreviewId { get; set; }
    public string Name { get; set; }
    public string AuthorId { get; set; }
    public Author Author { get; set; }
    public int ReleaseYear { get; set; }
    public AlbumType Type { get; set; }
    public List<Track> Tracks { get; } = new();

    public Album(string name, Author author, AlbumType albumType, int releaseYear, string previewId) : this(name,
        author, albumType, previewId)
    {
        ReleaseYear = releaseYear;
    }

    public Album(string name, Author author, AlbumType albumType, string previewId)
    {
        Name = name;
        // Author = author;
        AuthorId = author.Id;
        Type = albumType;
        ReleaseYear = DateTime.Now.Year;
        PreviewId = previewId;
    }

    public void AddTracks(params Track[] tracks) => Tracks.AddRange(tracks);

    public Album()
    {
    }
}