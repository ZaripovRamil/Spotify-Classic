using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Models.Entities.Enums;
using Models.Entities.Joints;

namespace Models.Entities;

[PrimaryKey("Id")]
public sealed class User : IdentityUser
{
    public List<Track> History { get; set; } = new();
    public List<UserTrack> UserTracks { get; set; } = new();
    public List<Playlist> Playlists { get; set; } = new();
    public string Name { get; set; } = default!;

    public Subscription? Subscription { get; set; }
    public string? SubscriptionId { get; set; }
    public DateTime? SubscriptionExpire { get; set; }

    public string ProfilePicId { get; set; } = "default_pfp";
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

    public User(string id, string login, string email, string name) : this(login, email, name)
    {
        Id = id;
    }
}