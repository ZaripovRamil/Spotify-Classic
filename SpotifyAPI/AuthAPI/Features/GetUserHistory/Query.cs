using Models.Entities;
using Utils.CQRS;

namespace AuthAPI.Features.GetUserHistory;

public record Query(User? User) : IQuery<ResultDto>;