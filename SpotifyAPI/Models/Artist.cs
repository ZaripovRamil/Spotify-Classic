namespace Models;

public class Artist
{
    public string Id = Guid.NewGuid().ToString();
    public string Name { get; set; }
    public List<Album> Albums { get; set; }
}