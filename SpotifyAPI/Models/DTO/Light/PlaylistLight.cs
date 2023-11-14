using Models.DTO.Full;
using Models.Entities;

namespace Models.DTO.Light;

public class PlaylistLight
{
    public string Id { get; set; } = default!;
    public string PreviewId { get; set; } = default!;
    public string Name { get; set; } = default!;
    public UserLight Owner { get; set; } = default!;
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

    public PlaylistLight()
    {
    }
}