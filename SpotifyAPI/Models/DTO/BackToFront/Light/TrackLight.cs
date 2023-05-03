using Models.DTO.BackToFront.Full;
using Models.Entities;

namespace Models.DTO.BackToFront.Light;

public class TrackLight
{
    public string Id { get; set; }
    public string FileId { get; set; }
    public string Name { get; set; }
    public AlbumLight Album { get; set; }

    public TrackLight() { }

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