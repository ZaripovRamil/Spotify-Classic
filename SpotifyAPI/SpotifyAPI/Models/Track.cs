namespace SpotifyAPI.Models;

public class Track
{
    public string Id = Guid.NewGuid().ToString();
    public string Name { get; set; }
    public Album Album { get; set; }
    public List<Playlist> InPlaylists { get; set; }
    public List<Genre> Genres { get; set; }
    public List<User> Histiry { get; set; }
}