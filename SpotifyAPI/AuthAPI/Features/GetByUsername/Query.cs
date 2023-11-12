using Models.Entities;
using Utils.CQRS;

namespace AuthAPI.Features.GetByUsername;

public record Query(string Username, User? RequestingUser) : IQuery<ResultDto>;