using Utils.CQRS;

namespace StaticAPI.Features.Track.GetById;

public record Query(string Id) : IQuery<Stream>;