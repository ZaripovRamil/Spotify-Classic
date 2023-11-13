using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Models.Entities;
using Models.Entities.Enums;
using Models.Entities.Joints;

namespace DatabaseServices.Repositories;

public interface IUserRepository : IUniqueNameEntityRepository<User>
{
    public Task<User?> GetByEmailAsync(string email);
    public Task SetRoleAsync(User user, Role role);
    Task AddTrackToHistoryAsync(User user, Track track);
    public Task<List<Track>> GetUserHistory(string userId);
}

public class UserRepository : Repository, IUserRepository
{
    public UserRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<User?> GetByIdAsync(string id) =>
        await GetUsers()
            .FirstOrDefaultAsync(u => u.Id == id);

    public IQueryable<User> GetAll()
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

    public Task DeleteAsync(User item)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(User item)
    {
        throw new NotImplementedException();
    }

    public async Task<User?> GetByNameAsync(string name) =>
        await GetUsers()
            .FirstOrDefaultAsync(u => u.UserName == name);

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


    public async Task AddAsync(User user)
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

    public async Task<List<Track>> GetUserHistory(string userId)
    {
        return (await GetByIdAsync(userId))?.History ?? new List<Track>();
    }
}