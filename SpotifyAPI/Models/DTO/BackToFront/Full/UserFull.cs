using Models.DTO.BackToFront.Light;
using Models.Entities;
using Models.Entities.Enums;

namespace Models.DTO.BackToFront.Full;

public class UserFull
{
    public UserFull(User user)
    {
        Id = user.Id;
        ProfilePicId = user.ProfilePicId;
        Name = user.Name;
        Playlists = user.Playlists.Select(p => new PlaylistLight(p)).ToList();
        History = user.History.Select(t => new TrackLight(t)).ToList();
        Role = user.Role;
        Email = user.Email;
    }

    public string Id { get; set; }
    public string ProfilePicId { get; set; }
    public string Name { get; set; }
    public Role Role { get; set; }
    public string Email { get; set; }
    public List<TrackLight> History { get; set; }
    public List<PlaylistLight> Playlists { get; set; }
}