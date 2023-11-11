using System.Linq.Expressions;
using Database;
using Microsoft.EntityFrameworkCore;

namespace DatabaseServices.Repositories;

public interface IRepository<T>
{
    Task AddAsync(T item);
    Task<T?> GetByIdAsync(string id);
    protected IQueryable<T> GetAll();
    Task DeleteAsync(T item);
    Task UpdateAsync(T item);

    IAsyncEnumerable<T> FilterAsync(Expression<Func<T, bool>> filter) => GetAll().Where(filter).AsAsyncEnumerable();
    IAsyncEnumerable<T> GetAllAsync() => GetAll().AsAsyncEnumerable();
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