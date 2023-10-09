namespace Models.Configuration;

public class JwtTokenSettings
{
    public string Issuer { get; set; } = default!;
    public string Audience { get; set; } = default!;
    public string Key { get; set; } = default!;
    public int Lifetime { get; set; } = default!;
}