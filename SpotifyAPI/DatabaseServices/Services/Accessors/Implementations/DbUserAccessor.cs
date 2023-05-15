using Database;
using DatabaseServices.Services.Accessors.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Models.Entities.Enums;
using Models.Entities.Joints;

namespace DatabaseServices.Services.Accessors.Implementations;

public class DbUserAccessor : DbAccessor, IDbUserAccessor
{
    public DbUserAccessor(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<User?> GetById(string id) =>
        await DbContext.Users
            .Include(u => u.History)
            .ThenInclude(t => t.Album)
            .ThenInclude(a => a.Author)
            .FirstOrDefaultAsync(u => u.Id == id);

    public async Task<User?> GetByUsername(string username) =>
        await DbContext.Users
            .Include(u => u.History)
            .ThenInclude(t => t.Album)
            .ThenInclude(a => a.Author)
            .FirstOrDefaultAsync(u => u.UserName == username);

    public async Task<User?> GetByEmail(string email) =>
        await DbContext.Users
            .Include(u => u.History)
            .ThenInclude(t => t.Album)
            .ThenInclude(a => a.Author)
            .FirstOrDefaultAsync(u => u.Email == email);

    public async Task AddUser(User user)
    {
        await DbContext.Users.AddAsync(user);
        await DbContext.SaveChangesAsync();
    }

    public async Task SetRole(User user, Role role)
    {
        user.Role = role;
        await DbContext.SaveChangesAsync();
    }

    public async Task AddTrackToHistory(User user, Track track)
    {
        var userTrack = new UserTrack(user, track);

        user.UserTracks.Add(userTrack);
        track.UserTracks.Add(userTrack);

        await DbContext.SaveChangesAsync();
    }
}