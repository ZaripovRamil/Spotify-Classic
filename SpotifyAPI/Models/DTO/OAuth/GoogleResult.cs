using System.Text.Json.Serialization;

namespace Models.DTO.OAuth;

public class GoogleResult
{
    [JsonPropertyName("access_token")] public string AccessToken { get; set; } = default!;
    [JsonPropertyName("id_token")] public string IdToken { get; set; } = default!;
}