namespace Models;

public class Album
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; }
    public Artist Artist { get; set; }
    public List<Track> Tracks { get; set; }
}