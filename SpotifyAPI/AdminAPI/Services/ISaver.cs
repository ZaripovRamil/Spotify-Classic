using Utils.CQRS;

namespace AdminAPI.Services;

public interface ISaver<in T, TResult>
{
    Task<Result<TResult>> SaveAsync(T item);
    Task<Result> UnSaveAsync(T item);
}