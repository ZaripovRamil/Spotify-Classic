using Utils.CQRS;

namespace AdminAPI.Services;

public interface ISaver<in T>
{
    Task<Result> SaveAsync(T item);
    Task<Result> UnSaveAsync(T item);
}