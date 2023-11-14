using Models.DTO.Light;
using Utils.CQRS;

namespace AdminAPI.Features.Users.GetAll;

public record Query : IQuery<IEnumerable<UserLight>>;