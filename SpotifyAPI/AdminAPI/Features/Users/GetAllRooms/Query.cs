using Utils.CQRS;

namespace AdminAPI.Features.Users.GetAllRooms;

public record Query : IQuery<IEnumerable<string>>;