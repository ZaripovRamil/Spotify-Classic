using DatabaseServices.Repositories;
using Models.DTO.Light;
using Utils.CQRS;

namespace SearchAPI.Features.SearchUsers;

public class QueryHandler : IQueryHandler<Query, ResultDto>
{
    private readonly IUserRepository _userRepository;

    public QueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Result<ResultDto>> Handle(Query request, CancellationToken cancellationToken)
    {
        return new ResultDto(
            await _userRepository
                .FilterAsync(Spec.NameContains(request.Filter) || Spec.UserNameContains(request.Filter))
                .AsAsyncEnumerable()
                .Select(u => new UserLight(u))
                .ToListAsync(cancellationToken: cancellationToken));
    }
}