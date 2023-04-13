using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Models.Entities.Enums;

namespace Models.Entities;

[PrimaryKey("Id")]
public class User : IdentityUser
{
    public List<Track> History { get; set; } = new();
    public List<Playlist> Playlists { get; set; } = new();
    public string Name { get; set; }
    public Role Role { get; set; }

    public User()
    {
    }

    public User(string login, string email, string name)
    {
        Name = name;
        Email = email;
        UserName = login;
    }
}