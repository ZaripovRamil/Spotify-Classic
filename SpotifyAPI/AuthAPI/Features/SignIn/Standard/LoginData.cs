namespace AuthAPI.Features.SignIn.Standard;

public record LoginData(string Username, string? Password, bool RememberMe);