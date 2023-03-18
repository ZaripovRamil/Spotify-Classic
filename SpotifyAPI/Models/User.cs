using Microsoft.EntityFrameworkCore;

namespace Models;

[PrimaryKey("Id")]

public class User
{
    public string Id { get; set; }
    public List<Track> History { get; set; }
    public string Login { get; set; }
    public string Email { get; set; }
    public Role Role{ get; set; }
    public string Salt { get; set; }
    public string Password { get; set; }

    public User(string login, string email, string salt, string password)
    {
        History = new List<Track>();
        Id = Guid.NewGuid().ToString();
        Login = login;
        Email = email;
        Role = Role.Free;
        Salt = salt;
        Password = password;
    }
    public User()
    {
    }

}