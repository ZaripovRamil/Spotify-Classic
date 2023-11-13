using Utils.CQRS;

namespace StaticAPI.Features.Preview.GetById;

public record Query(Guid Id) : IQuery<Stream>;