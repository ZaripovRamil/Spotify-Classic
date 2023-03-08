namespace Models;

public class Genre
{
    public string Id = Guid.NewGuid().ToString();
    public string Name { get; set; }
    public List<Track> Tracks { get; set; }
}