using Models;
using Models.DTO;
using Models.DTO.FrontToBack.EntityCreationData;

namespace AuthService.Services;

public interface IDbRequester
{
    public Task<User?> GetUserByUsername(string username);
    public Task<User?> GetUserByEmail(string email);
    public void AddUserToDb(RegistrationData rData);
}