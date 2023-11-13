using DatabaseServices;
using Microsoft.AspNetCore.Identity;
using Models.Entities;
using Utils.CQRS;

namespace AuthAPI.Features.GetByUsername;

public class QueryHandler : IQueryHandler<Query, ResultDto>
{
    private readonly UserManager<User> _userManager;
    private readonly IDtoCreator _dtoCreator;

    public QueryHandler(UserManager<User> userManager, IDtoCreator dtoCreator)
    {
        _userManager = userManager;
        _dtoCreator = dtoCreator;
    }

    public Task<Result<ResultDto>> Handle(Query request, CancellationToken cancellationToken)
    {
        var user = request.RequestingUser;
        return Task.FromResult(new Result<ResultDto>(new ResultDto(user != null && user.UserName == request.Username
            ? _dtoCreator.CreateFull(user)
            : _dtoCreator.CreateLight(_userManager.Users.FirstOrDefault(u => u.UserName == request.Username)))));
    }
}