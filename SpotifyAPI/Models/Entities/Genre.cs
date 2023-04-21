using Microsoft.EntityFrameworkCore;
using Models.Entities.Joints;

namespace Models.Entities;

[PrimaryKey("Id")]
public class Genre
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public Genre(string id, string name) : this(name)
    {
        Id = id;
    }
    
    public Genre(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public List<Track> Tracks { get; set; }
    public List<GenreTrack> GenreTracks { get; set; }
}