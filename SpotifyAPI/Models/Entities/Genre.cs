using Microsoft.EntityFrameworkCore;

namespace Models.Entities;

[PrimaryKey("Id")]
public class Genre
{
    public string Id{ get; set; } = Guid.NewGuid().ToString();

    public Genre(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public List<Track> Tracks { get; set; }
}