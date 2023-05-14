using Models.DTO.FrontToBack.Auth;
using Models.Entities;

namespace DatabaseServices.Services;

public interface IDbUserRequester
{
    public Task<User?> GetUserByUsername(string username);
    public Task<User?> GetUserByEmail(string email);
    public void AddUserToDb(RegistrationData rData);
}