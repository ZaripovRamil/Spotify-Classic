using System.Text.Json.Serialization;
using Models.Entities;

namespace Models.DTO.BackToFront.Light;

public class AlbumLight
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("author")]
    public AuthorLight Author { get; set; }

    public AlbumLight() { }

    public AlbumLight(Album album)
    {
        Id = album.Id;
        Name = album.Name;
        Author = new AuthorLight(album.Author);
    }
}