using System.Text.Json.Serialization;

namespace AuthAPI.Dto.OAuth;

public class GoogleUserInfoDto
{
    [JsonPropertyName("id")] public string Id { get; set; } = default!;
    [JsonPropertyName("name")] public string Name { get; set; } = default!;
    [JsonPropertyName("given_name")] public string GivenName { get; set; } = default!;
    [JsonPropertyName("family_name")] public string FamilyName { get; set; } = default!;
    [JsonPropertyName("email")] public string Email { get; set; } = default!;
}