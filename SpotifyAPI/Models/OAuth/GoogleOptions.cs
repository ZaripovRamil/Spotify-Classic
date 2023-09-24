namespace Models.OAuth;

public class GoogleOptions
{
    public string ClientId { get; set; } = default!;
    public string ClientSecret { get; set; } = default!;
    public string State { get; set; } = default!;
}