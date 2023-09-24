namespace Models.Entities.Joints;

public class GenreTrack
{
    public string GenreId { get; set; } = default!;
    public string TrackId { get; set; } = default!;
    public Genre Genre { get; set; } = default!;
    public Track Track { get; set; } = default!;

    public GenreTrack()
    {
    }

    public GenreTrack(Genre genre, Track track)
    {
        GenreId = genre.Id;
        TrackId = track.Id;
    }
}