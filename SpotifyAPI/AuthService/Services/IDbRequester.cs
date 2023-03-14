using Models;
using Models.DTO;

namespace AuthService.Services;

public interface IDbRequester
{
    public Task<User?> GetUserByLogin(string login);
    public Task<User?> GetUserByEmail(string email);
    public void AddUserToDb(RegistrationData rData);
}