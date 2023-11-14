namespace AuthAPI.Features.GetStatistics.Dto;

public class StatisticSnapshot
{
    public int TotalListens { get; set; }
    public TrackData[] Tracks { get; set; } = Array.Empty<TrackData>();
    public AuthorData[] Authors { get; set; } = Array.Empty<AuthorData>();
    public GenreData[] Genres { get; set; } = Array.Empty<GenreData>();
}