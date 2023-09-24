namespace Models.OAuth;

public class GoogleUserDto
{
    public string AccessToken { get; set; } = default!;
    public string IdToken { get; set; } = default!;
}