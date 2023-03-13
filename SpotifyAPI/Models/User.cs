using Microsoft.EntityFrameworkCore;
using Models.DTO;
using Models.Services;

namespace Models;

[PrimaryKey("Id")]

public class User
{
    public string Id = Guid.NewGuid().ToString();
    public List<Track> History { get; set; }
    public string Login { get; set; }
    public string Email { get; set; }
    public Role Role{ get; set; }
    public string Salt { get; set; }
    public string Password { get; set; }

    public User(string login, string email, string password)
    {
        Login = login;
        Email = email;
        Role = Role.Free;
        Salt = HashingService.GenerateSalt();
        Password = HashingService.GenerateHash(password, Salt);
    }

    public User(RegistrationData rData) : this(rData.Login, rData.Email, rData.Password)
    {
    }

}