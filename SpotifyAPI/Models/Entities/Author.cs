using Microsoft.EntityFrameworkCore;

namespace Models.Entities;

[PrimaryKey("Id")]
public class Author
{
    public Author(string name, string userId)
    {
        Name = name;
        UserId = userId;
    }

    public Author(string name, User user)
    {
        Name = name;
        UserId = user.Id;
    }

    public Author(User user)
    {
        Name = user.Name;
        UserId = user.Id;
        // User = user;
    }

    public void AddAlbums(params Album[] albums) => Albums.AddRange(albums);

    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string UserId { get; set; }
    public User User { get; set; }
    public string Name { get; set; }
    public List<Album> Albums { get; set; } = new();

    public Author()
    {
    }
}