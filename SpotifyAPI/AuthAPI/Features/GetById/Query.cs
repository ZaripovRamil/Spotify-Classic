using Models.Entities;
using Utils.CQRS;

namespace AuthAPI.Features.GetById;

public record Query(string Id, User? RequestingUser) : IQuery<ResultDto>;