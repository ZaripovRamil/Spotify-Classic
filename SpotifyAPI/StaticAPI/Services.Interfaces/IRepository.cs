namespace StaticAPI.Services.Interfaces;

public interface IRepository<T>
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(string id);
    Task CreateAsync(T newItem);
    Task UpdateAsync(T itemToUpdate);
    Task DeleteAsync(string id);
}