namespace Models.Entities.Joints;

public class PlaylistTrack
{
    public PlaylistTrack(string playlistId, string trackId)
    {
        PlaylistId = playlistId;
        TrackId = trackId;
    }
    
    public string PlaylistId { get; set; }
    public string TrackId { get; set; }
}