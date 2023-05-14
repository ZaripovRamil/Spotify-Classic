using Models.DTO.BackToFront.Full;
using Models.Entities;

namespace Models.DTO.BackToFront.Light;

public class PlaylistLight
{
    public string Id { get; set; }
    public string PreviewId { get; set; }
    public string Name { get; set; }
    public UserLight Owner { get; set; }
    public int TrackCount { get; set; }

    public PlaylistLight(Playlist playlist)
    {
        Id = playlist.Id;
        PreviewId = playlist.PreviewId;
        Name = playlist.Name;
        TrackCount = playlist.Tracks.Count;
        Owner = new UserLight(playlist.Owner);
    }
    
    public PlaylistLight(PlaylistFull playlist)
    {
        Id = playlist.Id;
        PreviewId = playlist.PreviewId;
        Name = playlist.Name;
        Owner = playlist.Owner;
        TrackCount = playlist.Tracks.Count;
    }
}