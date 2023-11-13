using DatabaseServices.Repositories;
using Models.DTO.BackToFront.Light;
using Utils.CQRS;

namespace AdminAPI.Features.Users.GetAll;

public class QueryHandler : IQueryHandler<Query, IEnumerable<UserLight>>
{
    private readonly IUserRepository _userRepository;

    public QueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Result<IEnumerable<UserLight>>> Handle(Query request, CancellationToken cancellationToken)
    {
        return await _userRepository.GetAllAsync().Select(u => new UserLight(u))
            .ToListAsync(cancellationToken: cancellationToken);
    }
}