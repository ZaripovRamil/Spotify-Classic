using Microsoft.AspNetCore.Identity;
using Models.DTO.Full;
using Models.DTO.Light;
using Models.Entities;
using Utils.CQRS;

namespace AuthAPI.Features.GetByUsername;

public class QueryHandler : IQueryHandler<Query, ResultDto>
{
    private readonly UserManager<User> _userManager;

    public QueryHandler(UserManager<User> userManager)
    {
        _userManager = userManager;
    }

    public Task<Result<ResultDto>> Handle(Query request, CancellationToken cancellationToken)
    {
        var user = _userManager.Users.FirstOrDefault(u => u.UserName == request.Username);
        return Task.FromResult(new Result<ResultDto>(new ResultDto(
            request.RequestingUser != null && request.RequestingUser.UserName == request.Username
                ?
                request.RequestingUser == null ? null : new UserFull(request.RequestingUser)
                : user == null
                    ? null
                    : new UserLight(user))));
    }
}