using DatabaseServices.Services.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;
using Models.DTO.BackToFront.Light;
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
            await _userRepository.GetAllUsers()
                .Where(Spec.NameContains(request.Filter) || Spec.UserNameContains(request.Filter))
                .AsAsyncEnumerable()
                .Select(u => new UserLight(u))
                .ToListAsync(cancellationToken: cancellationToken));
    }
}