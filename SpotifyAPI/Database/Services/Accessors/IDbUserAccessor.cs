using Models;

namespace Database.Controllers.Accessors;

public interface IDbUserAccessor
{
    public Task<User?> UserByLogin(string login);

    public Task<User?> UserById(string id);

    public Task<User?> UserByEmail(string email);
    public Task AddUser(User user);
    public Task SetRole(User user, Role role);
}