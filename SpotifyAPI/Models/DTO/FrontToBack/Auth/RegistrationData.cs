namespace Models.DTO.FrontToBack.Auth;

public class RegistrationData
{
    public string Login { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Password { get; set; } = default!;
}