namespace Models.Entities;

public class Entity
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; }
}