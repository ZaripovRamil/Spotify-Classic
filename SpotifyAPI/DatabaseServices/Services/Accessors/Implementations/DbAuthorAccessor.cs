using Database;
using DatabaseServices.Services.Accessors.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DatabaseServices.Services.Accessors.Implementations;

public class DbAuthorAccessor : DbAccessor, IDbAuthorAccessor
{
    public DbAuthorAccessor(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task Add(Author author)
    {
        await DbContext.Authors.AddAsync(author);
        await DbContext.SaveChangesAsync();
    }

    public IEnumerable<Author> GetAll() => DbContext.Authors;
    
    public async Task Delete(Author author)
    {
        DbContext.Authors.Remove(author);
        await DbContext.SaveChangesAsync();
    }

    public async Task<Author?> GetById(string id)
    {
        return await DbContext.Authors
            .Include(a => a.Albums)
            .FirstOrDefaultAsync(a => a.Id == id);
    }

    public async Task<Author?> GetByName(string name)
    {
        return await DbContext.Authors
            .Include(a => a.Albums)
            .FirstOrDefaultAsync(a => a.Name == name);
    }
}