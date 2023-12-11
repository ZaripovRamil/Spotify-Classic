using Utils.CQRS;

namespace AdminAPI.Services;

public interface IMetadataCreator<in T,TResult>
{
    Task<Result<TResult>> CreateMetadata(T item);
}