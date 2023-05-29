using Microsoft.EntityFrameworkCore;
using Models.Entities.Joints;

namespace Models.Entities;

[PrimaryKey("Id")]
public class Genre : Entity
{
    public Genre(string id, string name) : this(name)
    {
        Id = id;
    }

    public Genre(string name)
    {
        Name = name;
    }

    public List<Track> Tracks { get; set; } = new();
    public List<GenreTrack> GenreTracks { get; set; } = new();
}