using DatabaseServices.Repositories;
using Models.DTO.Full;
using Utils.CQRS;

namespace AdminAPI.Features.Authors.Get.All;

public class QueryHandler : IQueryHandler<Query, IEnumerable<AuthorFull>>
{
    private readonly IAuthorRepository _authorRepository;

    public QueryHandler(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }

    public async Task<Result<IEnumerable<AuthorFull>>> Handle(Query request, CancellationToken cancellationToken)
    {
        var authors = await _authorRepository.GetAllAsync().Select(a => new AuthorFull(a))
            .ToListAsync(cancellationToken: cancellationToken);
        return new Result<IEnumerable<AuthorFull>>(authors);
    }
}