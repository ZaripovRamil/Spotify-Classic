namespace Models.Entities;

public class Author
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; }
    public List<Album> Albums { get; set; }
    
}