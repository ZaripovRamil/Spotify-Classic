using Models;

namespace Database.Services.Accessors;

public interface IDbUserAccessor
{
    public Task<User?> GetByUsername(string login);

    public Task<User?> GetById(string id);

    public Task<User?> UserByEmail(string email);
    public Task AddUser(User user);
    public Task SetRole(User user, Role role);
}