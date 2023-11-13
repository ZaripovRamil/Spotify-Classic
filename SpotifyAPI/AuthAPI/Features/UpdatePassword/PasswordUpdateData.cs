namespace AuthAPI.Features.UpdatePassword;

public record PasswordUpdateData(string OldPassword, string Password, string RepeatPassword);