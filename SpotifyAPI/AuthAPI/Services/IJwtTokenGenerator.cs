namespace AuthAPI.Services;

public interface IJwtTokenGenerator
{
    public Task<string?> GenerateJwtTokenAsync(string username, TimeSpan additionalLifetime);

    public Task<string?> GetRoleAsync(string username);

    public Task<bool> ValidateTokenAsync(string token);
}