using Models.DTO.BackToFront.Light;
using Models.Entities;

namespace Models.DTO.BackToFront.Full;

public class PlaylistFull
{
    public PlaylistFull(Playlist playlist)
    {
        Id = playlist.Id;
        PreviewId = playlist.PreviewId;
        Name = playlist.Name;
        Owner = new UserLight(playlist.Owner);
        Tracks = playlist.Tracks.Select(t => new TrackLight(t)).ToList();
    }

    public string Id { get; set; }
    public string PreviewId { get; set; }
    public string Name { get; set; }
    public UserLight Owner { get; set; }
    public List<TrackLight> Tracks { get; set; }

    public PlaylistFull() { }
}