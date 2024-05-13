namespace Models.DTO.Auth;

public record LoginData(string? Username, string? Password, bool RememberMe);