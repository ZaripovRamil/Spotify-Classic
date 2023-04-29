using Microsoft.EntityFrameworkCore;

namespace Models.Entities;

[PrimaryKey("Id")]
public class Author:Entity
{
    public Author(string name, User user)
    {
        Name = name;
        UserId = user.Id;
    }

    public Author(string id, User user, string name)
    {
        Id = id;
        Name = name;
        UserId = user.Id;
        // User = user;
    }

    public void AddAlbums(params Album[] albums) => Albums.AddRange(albums);
    
    public string UserId { get; set; }
    public User User { get; set; }
    public List<Album> Albums { get; set; } = new();
    
    public Author() { }
}