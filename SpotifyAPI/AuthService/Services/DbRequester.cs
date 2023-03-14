
using Models;
using Database.Services;
using Models.DTO;

namespace AuthService.Services;

public static class DbRequester
{
    private static readonly HttpClient Client = new();

    public static async Task<User?> GetUserByLogin(string login) =>
        await Client.GetDataAsync<User?>($"User/get/login/{login}");
    public static async Task<User?> GetUserByEmail(string email) =>
        await Client.GetDataAsync<User?>($"User/get/email/{email}");

    public static void AddUserToDb(RegistrationData rData) => 
        Client.PostDataAsync("User/Add", rData);
}
