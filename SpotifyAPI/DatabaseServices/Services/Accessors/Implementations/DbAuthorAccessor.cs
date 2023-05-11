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

    // Inefficient. If the author is already known, why to find it again?
    // Honestly, I just didn't figure out how to do it more maintainable.
    // It could receive the name parameter for the author to update, but what if 
    // in future we want to be able to change not only Name?
    // In the current implementation we only should add new lines here
    // and in the calling code to create a valid author instance.
    // May be separate this method to UpdateName, UpdateSmthElse, etc?
    // but it seems to be too much work...
    public async Task Update(Author author)
    {
        var toChange = (await GetById(author.Id))!;
        toChange.Name = author.Name;
        await DbContext.SaveChangesAsync();
    }

    public async Task<Author?> GetById(string id)
    {
        return await DbContext.Authors
            .Include(a => a.User)
            .Include(a => a.Albums)
            .FirstOrDefaultAsync(a => a.Id == id);
    }

    public async Task<Author?> GetByName(string name)
    {
        return await DbContext.Authors
            .Include(a => a.User)
            .Include(a => a.Albums)
            .FirstOrDefaultAsync(a => a.Name == name);
    }

    public IEnumerable<Author> GetAll()
    {
        return DbContext.Authors.Include(a => a.Albums);
    }
}