using System.Text.Json.Serialization;
using Models.Entities;

namespace Models.DTO.BackToFront.Light;

public class AuthorLight
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }

    public AuthorLight() { }
    
    public AuthorLight(Author author)
    {
        Id = author.Id;
        Name = author.Name;
    }
}