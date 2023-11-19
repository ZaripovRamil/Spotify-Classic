using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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

    public async Task<Result<ResultDto>> Handle(Query request, CancellationToken cancellationToken)
    {
        var user = await _userManager.Users.FirstOrDefaultAsync(u => u.UserName == request.Username,
            cancellationToken: cancellationToken);

        if (request.RequestingUser != null && request.RequestingUser.UserName == request.Username)
            return new ResultDto(request.RequestingUser == null ? null : new UserFull(request.RequestingUser));

        return new ResultDto(user == null ? null : new UserLight(user));
    }
}