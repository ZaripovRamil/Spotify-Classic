using Models.DTO.Light;
using Models.Entities;

namespace Models.DTO.Full;

public class TrackFull
{
    public string Id { get; set; } = default!;
    public string FileId { get; set; } = default!;
    public string Name { get; set; } = default!;
    public AlbumLight Album { get; set; } = default!;
    public List<GenreLight> Genres { get; set; } = default!;

    public TrackFull()
    {
    }

    public TrackFull(Track track)
    {
        Id = track.Id;
        FileId = track.FileId;
        Name = track.Name;
        Album = new AlbumLight(track.Album);
        Genres = track.Genres.Select(g => new GenreLight(g)).ToList();
    }
}