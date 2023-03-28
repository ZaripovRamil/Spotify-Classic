using Models.DTO.BackToFront.Light;

namespace Models.DTO.BackToFront.Full;

public class UserFull
{
    public UserFull(User user)
    {
        Id = user.Id;
        Name = user.Name;
        Playlists = user.Playlists.Select(p=>new PlaylistLight(p)).ToList();
        History = user.History.Select(t => new TrackLight(t)).ToList();
    }

    public string Id { get; set; }
    public string Name { get; set; }
    public List<TrackLight> History { get; set; }
    public List<PlaylistLight> Playlists { get; set; }
}