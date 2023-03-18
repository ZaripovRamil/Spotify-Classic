
using Database.Extensions;
using Models;
using Models.DTO;

namespace AuthService.Services;

public  class DbRequester:IDbRequester
{
    private static readonly HttpClient Client = new();

    public async Task<User?> GetUserByLogin(string login) =>
        await Client.GetDataAsync<User?>($"User/get/login/{login}");
    
    public async Task<User?> GetUserByEmail(string email) =>
        await Client.GetDataAsync<User?>($"User/get/email/{email}");

    public void AddUserToDb(RegistrationData rData) => 
        Client.PostDataAsync("User/Add", rData);
}
