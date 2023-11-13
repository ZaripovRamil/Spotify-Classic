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

    public async Task UpdateAsync(Author author)
    {
        DbContext.Authors.Update(author);
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
            .Include(a => a.Albums)
            .AsNoTracking();
    }
}