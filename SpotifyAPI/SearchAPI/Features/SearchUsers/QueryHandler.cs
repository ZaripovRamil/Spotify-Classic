using DatabaseServices.Services.Repositories.Implementations;
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

    public Task<Result<ResultDto>> Handle(Query request, CancellationToken cancellationToken)
    {
        return Task.FromResult<Result<ResultDto>>(
            new ResultDto(
                _userRepository.GetAllUsers()
                    .Where(Spec.NameContains(request.Filter) || Spec.UserNameContains(request.Filter))
                    .AsEnumerable()
                    .Select(u => new UserLight(u))
                    .ToList()
                )
            );
    }
}