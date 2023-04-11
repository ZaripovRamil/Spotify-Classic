using Models.DTO.BackToFront.Light;
using Models.Entities;

namespace Models.DTO.BackToFront.Full;

public class TrackFull
{
    public string Id { get; set; }
    public string FileId { get; set; }
    public string Name { get; set; }
    public AlbumLight Album { get; set; }
    public List<GenreLight>Genres { get; set; }

    public TrackFull(Track track)
    {
        Id = track.Id;
        FileId = track.FileId;
        Name = track.Name;
        Album = new AlbumLight(track.Album);
        Genres = track.Genres.Select(g => new GenreLight(g)).ToList();
    }
}