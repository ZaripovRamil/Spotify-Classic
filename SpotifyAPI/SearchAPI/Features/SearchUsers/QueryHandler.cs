using DatabaseServices.Services.Repositories.Implementations;
using Models.DTO.BackToFront;
using Models.DTO.BackToFront.Light;
using Utils.CQRS;

namespace SearchAPI.Features.SearchUsers;

public class QueryHandler : IQueryHandler<Query, UsersSearchResult>
{
    private readonly IUserRepository _userRepository;

    public QueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public Task<Result<UsersSearchResult>> Handle(Query request, CancellationToken cancellationToken)
    {
        return Task.FromResult<Result<UsersSearchResult>>(
            new UsersSearchResult(
                _userRepository.GetAllUsers()
                    .Where(u => u.Name.ToLower().Contains(request.Filter.ToLower()) ||
                                u.NormalizedUserName is not null &&
                                u.NormalizedUserName.Contains(request.Filter.ToUpper()))
                    .Select(u => new UserLight(u))
                    .ToList()
                )
            );
    }
}