using Models.DTO.BackToFront.Light;

namespace Models.DTO.BackToFront;

public class TracksSearchResult
{
    public TracksSearchResult(List<TrackLight> tracks)
    {
        Tracks = tracks;
    }
    
    public List<TrackLight> Tracks { get; set; }
}