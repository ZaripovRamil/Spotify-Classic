using System.Text.Json.Serialization;

namespace AuthAPI.Dto.OAuth;

public class GoogleLoginData
{
    [JsonPropertyName("id_token")] public string IdToken { get; set; } = default!;
    [JsonPropertyName("access_token")] public string AccessToken { get; set; } = default!;
}