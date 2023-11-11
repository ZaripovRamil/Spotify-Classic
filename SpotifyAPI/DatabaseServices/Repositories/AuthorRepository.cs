using Database;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DatabaseServices.Repositories;

public interface IAuthorRepository : IUniqueNameEntityRepository<Author>
{
}

public class AuthorRepository : Repository, IAuthorRepository
{
    public AuthorRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task AddAsync(Author author)
    {
        await DbContext.Authors.AddAsync(author);
        await DbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Author author)
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
    public async Task UpdateAsync(Author author)
    {
        var toChange = (await GetByIdAsync(author.Id))!;
        toChange.Name = author.Name;
        await DbContext.SaveChangesAsync();
    }

    public async Task<Author?> GetByIdAsync(string id)
    {
        return await GetAll()
            .FirstOrDefaultAsync(a => a.Id == id);
    }

    public async Task<Author?> GetByNameAsync(string name)
    {
        return await GetAll()
            .FirstOrDefaultAsync(a => a.Name == name);
    }

    public IQueryable<Author> GetAll()
    {
        return DbContext.Authors
            .Include(a => a.User)
            .Include(a => a.Albums);
    }
}