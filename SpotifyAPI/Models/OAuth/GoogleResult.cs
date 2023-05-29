using System.Text.Json.Serialization;

namespace Models.OAuth;

public class GoogleResult
{
    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; }
    [JsonPropertyName("id_token")]
    public string IdToken { get; set; }
}