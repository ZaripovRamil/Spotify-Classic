namespace Models.Entities.Joints;

public class GenreTrack
{
    public string GenreId { get; set; }
    public string TrackId { get; set; }
    public Genre Genre { get; set; }
    public Track Track { get; set; }

    public GenreTrack()
    {
    }

    public GenreTrack(Genre genre, Track track)
    {
        GenreId = genre.Id;
        TrackId = track.Id;
    }
}