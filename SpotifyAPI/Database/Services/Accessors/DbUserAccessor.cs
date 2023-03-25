using Microsoft.EntityFrameworkCore;
using Models;

namespace Database.Services.Accessors;

public class DbUserAccessor :DbAccessor, IDbUserAccessor
{
    public DbUserAccessor(AppDbContext dbContext):base(dbContext)
    {
    }
    
    public async Task<User?> GetById(string id) =>
        await DbContext.Users.FirstOrDefaultAsync(u => u.Id == id);

    public async Task<User?> GetByUsername(string username) =>
        await DbContext.Users.FirstOrDefaultAsync(u => u.UserName == username);

    public async Task<User?> UserByEmail(string email) =>
        await DbContext.Users.FirstOrDefaultAsync(u => u.Email == email);

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
}