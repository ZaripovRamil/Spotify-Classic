namespace AuthAPI.Services;

public interface IJwtTokenGenerator
{
    public Task<string?> GenerateJwtTokenAsync(string username);

    public Task<string?> GetRoleAsync(string username);
}