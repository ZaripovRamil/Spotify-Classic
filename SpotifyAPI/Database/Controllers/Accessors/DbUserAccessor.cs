using Microsoft.EntityFrameworkCore;
using Models;

namespace Database.Controllers.Accessors;

public class DbUserAccessor :DbAccessor, IDbUserAccessor
{
    public DbUserAccessor(AppDbContext dbContext):base(dbContext)
    {
    }
    
    public async Task<User?> UserById(string id) =>
        await DbContext.Users.FirstOrDefaultAsync(u => u.Id == id);

    public async Task<User?> UserByLogin(string login) =>
        await DbContext.Users.FirstOrDefaultAsync(u => u.Login == login);

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