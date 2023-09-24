namespace Models.DTO.FrontToBack.EntityUpdateData;

public class PasswordUpdateData
{
    public string OldPassword { get; set; } = default!;
    public string Password { get; set; } = default!;
    public string RepeatPassword { get; set; } = default!;
}