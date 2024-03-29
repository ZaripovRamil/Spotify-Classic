using DatabaseServices.Repositories;
using Models.DTO.Full;
using Utils.CQRS;

namespace SearchAPI.Features.SearchAuthorsByUser;

public class QueryHandler : IQueryHandler<Query, ResultDto>
{
    private readonly IAuthorRepository _authorRepository;

    public QueryHandler(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }

    public async Task<Result<ResultDto>> Handle(Query request, CancellationToken cancellationToken)
    {
        return new ResultDto(
            await _authorRepository
                .FilterAsync(Spec.NameContains(request.Filter) || Spec.UserNameContains(request.Filter))
                .AsAsyncEnumerable()
                .Select(a => new AuthorFull(a))
                .ToListAsync(cancellationToken: cancellationToken));
    }
}