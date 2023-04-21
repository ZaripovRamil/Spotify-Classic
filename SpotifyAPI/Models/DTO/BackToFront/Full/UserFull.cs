using Models.DTO.BackToFront.Light;
using Models.Entities;

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
    }

    public string Id { get; set; }
    public string ProfilePicId { get; set; }
    public string Name { get; set; }
    public List<TrackLight> History { get; set; }
    public List<PlaylistLight> Playlists { get; set; }
}