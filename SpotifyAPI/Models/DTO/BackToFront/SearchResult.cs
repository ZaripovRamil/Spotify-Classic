using Models.DTO.BackToFront.Light;

namespace Models.DTO.BackToFront;

public class SearchResult
{
    public SearchResult(List<TrackLight> tracks, List<AlbumLight> albums, List<AuthorLight> authors,
        List<PlaylistLight> playlists)
    {
        Tracks = tracks;
        Albums = albums;
        Authors = authors;
        Playlists = playlists;
    }

    public List<TrackLight> Tracks { get; set; }
    public List<AlbumLight> Albums { get; set; }
    public List<AuthorLight> Authors { get; set; }
    public List<PlaylistLight> Playlists { get; set; }
}