namespace Models;

public class Playlist
{
    public string Id = Guid.NewGuid().ToString();
    
    public string Name { get; set; }
    public User Owner { get; set; }
    public List<Track> Tracks = new List<Track>();
}