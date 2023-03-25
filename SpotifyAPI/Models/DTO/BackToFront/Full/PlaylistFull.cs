using Models.DTO.BackToFront.Light;

namespace Models.DTO.BackToFront.Full;

public class PlaylistFull
{
    public string Id { get; set; } 
    public string Name { get; set; }
    public User Owner { get; set; }
    public List<TrackLight> Tracks { get; set; }
}