namespace Models.DTO.BackToFront.Light;

public class PlaylistLight
{
    public string Id { get; set; } 
    public string Name { get; set; }
    public int TrackCount { get; set; }

    public PlaylistLight(Playlist playlist)
    {
        Id = playlist.Id;
        Name = playlist.Name;
        TrackCount = playlist.Tracks.Count;
    }
}