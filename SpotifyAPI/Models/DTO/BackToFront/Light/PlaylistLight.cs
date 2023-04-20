using Models.Entities;

namespace Models.DTO.BackToFront.Light;

public class PlaylistLight
{
    public string Id { get; set; }
    public string PreviewId { get; set; }
    public string Name { get; set; }
    public User Owner { get; set; }
    public int TrackCount { get; set; }

    public PlaylistLight(Playlist playlist)
    {
        Id = playlist.Id;
        PreviewId = playlist.PreviewId;
        Name = playlist.Name;
        TrackCount = playlist.Tracks.Count;
    }
}