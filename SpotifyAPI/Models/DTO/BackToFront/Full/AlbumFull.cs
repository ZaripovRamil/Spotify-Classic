using Models.DTO.BackToFront.Light;

namespace Models.DTO.BackToFront.Full;

public class AlbumFull
{
    public string Id { get; set; }
    public string Name { get; set; }
    public UserLight Author { get; set; }
    public List<TrackLight> Tracks { get; set; }

    public AlbumFull(Playlist album)
    {
        Id = album.Id;
        Name = album.Name;
        Author = new UserLight(album.Owner);
        Tracks = album.Tracks.Select(track => new TrackLight(track)).ToList();
    }
}