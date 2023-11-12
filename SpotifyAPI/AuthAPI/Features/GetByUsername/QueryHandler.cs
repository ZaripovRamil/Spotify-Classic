using System.Security.Principal;
using DatabaseServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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

    private async Task<User?> GetContextUser(IPrincipal requestingUser)
    {
        return await _userManager.Users
            .Include(u => u.Subscription)
            .Include(u => u.Playlists)
            .Include(u => u.Playlists)
            .ThenInclude(p => p.Tracks)
            .Include(u => u.History)
            .ThenInclude(t => t.Album)
            .ThenInclude(a => a.Author)
            .Include(u => u.History)
            .ThenInclude(t => t.Genres)
            .Include(u => u.Playlists)
            .FirstOrDefaultAsync(u => u.UserName == requestingUser.Identity!.Name);
    }
}