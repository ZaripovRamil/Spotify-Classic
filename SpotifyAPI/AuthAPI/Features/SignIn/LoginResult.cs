namespace AuthAPI.Features.SignIn;

public record LoginResult(bool IsSuccessful, string Token, string ResultMessage);