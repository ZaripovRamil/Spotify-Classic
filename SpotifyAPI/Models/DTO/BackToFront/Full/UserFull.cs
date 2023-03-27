using Models.DTO.BackToFront.Light;

namespace Models.DTO.BackToFront.Full;

public class UserFull
{
    public UserFull(User user)
    {
        ///TODO 
    }

    public string Id { get; set; }
    public string Name { get; set; }
    public List<TrackLight> History { get; set; }
    public List<PlaylistLight> Playlists { get; set; }
}