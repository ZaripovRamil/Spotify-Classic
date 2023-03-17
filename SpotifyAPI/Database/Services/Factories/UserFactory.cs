using Models;
using Models.DTO;
using Models.Services;

namespace Database.Services.Factories;

public class UserFactory : IUserFactory
{
    private IHashingService HashingService { get; }

    public UserFactory(IHashingService hashingService)
    {
        HashingService = hashingService;
    }

    private User Create(string login, string email, string password)
    {
        var salt = HashingService.GenerateSalt();
        var hashedPassword = HashingService.GenerateHash(password, salt);
        return new User(login, email, salt, hashedPassword);
    }

    public User Create(RegistrationData rData) => Create(rData.Login, rData.Email, rData.Password);
}