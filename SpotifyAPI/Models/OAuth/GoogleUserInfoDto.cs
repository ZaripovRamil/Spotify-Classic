using System.Text.Json.Serialization;

namespace Models.OAuth;

public class GoogleUserInfoDto
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("given_name")]
    public string GivenName { get; set; }
    [JsonPropertyName("family_name")]
    public string FamilyName { get; set; }
    [JsonPropertyName("email")]
    public string Email { get; set; }
}