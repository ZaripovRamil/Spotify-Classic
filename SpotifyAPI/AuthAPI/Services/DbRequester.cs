using DatabaseServices.Extensions;
using Models.DTO.FrontToBack.Auth;
using Models.Entities;

namespace AuthAPI.Services;

public class DbRequester : IDbRequester
{
    private static readonly HttpClient Client = new();

    public async Task<User?> GetUserByUsername(string username) =>
        await Client.GetDataAsync<User?>($"User/get/username/{username}");

    public async Task<User?> GetUserByEmail(string email) =>
        await Client.GetDataAsync<User?>($"User/get/email/{email}");

    public void AddUserToDb(RegistrationData rData) =>
        Client.PostDataAsync("User/Add", rData);
}