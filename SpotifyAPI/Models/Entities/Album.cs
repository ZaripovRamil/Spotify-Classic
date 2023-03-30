using Models.Entities.Enums;

namespace Models.Entities;

public class Album
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; }
    public Author Author { get; set; }
    public int ReleaseYear { get; set; }
    public AlbumType Type { get; set; }
    public List<Track> Tracks { get; set; } 
    
    public Album(string name, Author author, AlbumType albumType, int releaseYear):this(name,author,albumType)
    {
        ReleaseYear = releaseYear;
    }
    
    public Album(string name, Author author, AlbumType albumType)
    {
        Name = name;
        Author = author;
        Type = albumType;
        ReleaseYear = DateTime.Now.Year;
    }

    public Album()
    {
    }
}