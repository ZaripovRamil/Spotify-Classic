using System.Text.Json.Serialization;

namespace Models.OAuth;

public class GoogleLoginData
{
    [JsonPropertyName("id_token")]
    public string IdToken { get; set; }
    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; }
}