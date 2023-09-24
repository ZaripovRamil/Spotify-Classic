using Models.DTO.BackToFront.Full;
using Models.Entities;

namespace Models.DTO.BackToFront.Light;

public class TrackLight
{
    public string Id { get; set; } = default!;
    public string FileId { get; set; } = default!;
    public string Name { get; set; } = default!;
    public AlbumLight Album { get; set; } = default!;

    public TrackLight()
    {
    }

    public TrackLight(Track track)
    {
        Id = track.Id;
        Name = track.Name;
        Album = new AlbumLight(track.Album);
        FileId = track.FileId;
    }

    public TrackLight(TrackFull trackFull)
    {
        Id = trackFull.Id;
        FileId = trackFull.FileId;
        Name = trackFull.Name;
        Album = trackFull.Album;
    }
}