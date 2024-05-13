namespace Models.DTO.Auth;

public record LoginResult(bool IsSuccessful, string Token, string ResultMessage);