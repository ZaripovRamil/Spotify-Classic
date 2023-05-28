using Models.Entities;
using Models.Entities.Enums;

namespace DatabaseServices.Services.Accessors.Interfaces;

public interface IDbUserAccessor
{
    public IEnumerable<User> GetAllUsers();
    public Task<User?> GetByUsername(string login);

    public Task<User?> GetById(string id);

    public Task<User?> GetByEmail(string email);
    public Task AddUser(User user);
    public Task SetRole(User user, Role role);
    Task AddTrackToHistory(User user, Track track);
}