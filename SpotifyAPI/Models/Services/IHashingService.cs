namespace Models.Services;

public interface IHashingService
{
    public string GenerateSalt();
    public string GenerateHash(string password, string salt);
}