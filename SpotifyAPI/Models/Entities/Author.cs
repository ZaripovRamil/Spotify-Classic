namespace Models.Entities;

public class Author
{
    public Author(string name, string userId)
    {
        Name = name;
        UserId = userId;
        Albums = new List<Album>();
    }

    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string UserId { get; set; }
    public string Name { get; set; }
    public List<Album> Albums { get; set; }
    
    public Author()
    {}
}