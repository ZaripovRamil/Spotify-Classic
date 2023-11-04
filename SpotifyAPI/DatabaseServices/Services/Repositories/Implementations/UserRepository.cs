using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Models.Entities;
using Models.Entities.Enums;
using Models.Entities.Joints;

namespace DatabaseServices.Services.Repositories.Implementations;

public interface IUserRepository
{
    public IEnumerable<User> GetAllUsers();
    public Task<User?> GetByUsernameAsync(string login);

    public Task<User?> GetByIdAsync(string id);

    public Task<User?> GetByEmailAsync(string email);
    public Task AddUserAsync(User user);
    public Task SetRoleAsync(User user, Role role);
    Task AddTrackToHistoryAsync(User user, Track track);
}

public class UserRepository : Repository, IUserRepository
{
    public UserRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<User?> GetByIdAsync(string id) =>
        await GetUsers()
            .FirstOrDefaultAsync(u => u.Id == id);

    public IEnumerable<User> GetAllUsers()
    {
        var users = DbContext.Users
            .Include(u => u.Playlists)
            .Include(u => u.Playlists)
            .ThenInclude(p => p.Tracks)
            .ThenInclude(t => t.Album)
            .ThenInclude(a => a.Author)
            .Include(u => u.History)
            .ThenInclude(t => t.Album)
            .ThenInclude(a => a.Author);
        return users.Where(user => user.Role != Role.Admin);
    }

    public async Task<User?> GetByUsernameAsync(string login) =>
        await GetUsers()
            .FirstOrDefaultAsync(u => u.UserName == login);

    public async Task<User?> GetByEmailAsync(string email) =>
        await GetUsers()
            .FirstOrDefaultAsync(u => u.Email == email);

    private IIncludableQueryable<User, Author> GetUsers()
    {
        return DbContext.Users
            .Include(u => u.Subscription)
            .Include(u => u.Playlists)
            .Include(u => u.Playlists)
            .ThenInclude(p => p.Tracks)
            .Include(u => u.History)
            .ThenInclude(t => t.Album)
            .ThenInclude(a => a.Author);
    }


    public async Task AddUserAsync(User user)
    {
        await DbContext.Users.AddAsync(user);
        await DbContext.SaveChangesAsync();
    }

    public async Task SetRoleAsync(User user, Role role)
    {
        user.Role = role;
        await DbContext.SaveChangesAsync();
    }

    public async Task AddTrackToHistoryAsync(User user, Track track)
    {
        var userTrack = new UserTrack(user, track);

        user.UserTracks.Add(userTrack);
        track.UserTracks.Add(userTrack);

        await DbContext.SaveChangesAsync();
    }
}