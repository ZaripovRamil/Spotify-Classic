using System.Text.Json.Serialization;
using Models.Entities;

namespace Models.DTO.BackToFront.Light;

public class TrackLight
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("album")]
    public AlbumLight Album { get; set; }

    public TrackLight() { }

    public TrackLight(Track track)
    {
        Id = track.Id;
        Name = track.Name;
        Album = new AlbumLight(track.Album);
    }
}