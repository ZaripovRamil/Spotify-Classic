using Microsoft.EntityFrameworkCore;

namespace Models.Entities;

[PrimaryKey("Id")]
public class Author : Entity
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
    }

    public Author(string userId, string name)
    {
        UserId = userId;
        Name = name;
    }

    public Author()
    {
    }

    public void AddAlbums(params Album[] albums) => Albums.AddRange(albums);

    public string UserId { get; set; } = default!;
    public User User { get; set; } = default!;
    public List<Album> Albums { get; set; } = new();
}