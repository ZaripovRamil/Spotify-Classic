using Models.DTO.BackToFront.Light;

namespace Models.DTO.BackToFront.Statistics;

public class TrackData
{
    public TrackData(TrackLight track, int count)
    {
        Track = track;
        Count = count;
    }

    public TrackLight Track { get; set; }
    public int Count { get; set; }
}