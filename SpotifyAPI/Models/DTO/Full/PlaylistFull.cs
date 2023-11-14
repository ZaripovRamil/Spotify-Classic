using Models.DTO.Light;
using Models.Entities;

namespace Models.DTO.Full;

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

    public PlaylistFull()
    {
    }

    public string Id { get; set; } = default!;
    public string PreviewId { get; set; } = default!;
    public string Name { get; set; } = default!;
    public UserLight Owner { get; set; } = default!;
    public List<TrackLight> Tracks { get; set; } = default!;
}