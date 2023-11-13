using DatabaseServices;
using Microsoft.AspNetCore.Identity;
using Models.Entities;
using Utils.CQRS;

namespace AuthAPI.Features.GetById;

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
        return Task.FromResult(new Result<ResultDto>(new ResultDto(
            request.RequestingUser != null && request.RequestingUser.Id == request.Id
                ? _dtoCreator.CreateFull(request.RequestingUser)
                : _dtoCreator.CreateLight(_userManager.Users.FirstOrDefault(u => u.Id == request.Id)))));
    }
}