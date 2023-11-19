using Utils.CQRS;

namespace StaticAPI.Features.Preview.GetById;

public record Query(string Id) : IQuery<Stream>;