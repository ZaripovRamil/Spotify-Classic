namespace AuthAPI.Services;

public interface IJwtTokenGenerator
{
    public Task<string?> GenerateJwtTokenAsync(string username, TimeSpan lifetime);

    public Task<string?> GetRoleAsync(string username);
}