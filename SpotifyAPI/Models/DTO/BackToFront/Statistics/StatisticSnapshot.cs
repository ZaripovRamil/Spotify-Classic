namespace Models.DTO.BackToFront.Statistics;

public class StatisticSnapshot
{
    public int TotalListens { get; set; }
    public TrackData[] Tracks { get; set; }
    public AuthorData[] Authors { get; set; }
    public GenreData[] Genres { get; set; }
}