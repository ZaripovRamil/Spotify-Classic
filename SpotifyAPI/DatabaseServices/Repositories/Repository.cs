using Database;

namespace DatabaseServices.Repositories;

public interface IRepository<T>
{
    Task AddAsync(T item);
    Task<T?> GetByIdAsync(string id);
    IQueryable<T> GetAll();
    Task DeleteAsync(T item);
    Task UpdateAsync(T item);
}

public interface IUniqueNameEntityRepository<T> : IRepository<T>
{
    Task<T?> GetByNameAsync(string name);
}

public abstract class Repository
{
    protected AppDbContext DbContext { get; }

    protected Repository(AppDbContext dbContext)
    {
        DbContext = dbContext;
    }
}