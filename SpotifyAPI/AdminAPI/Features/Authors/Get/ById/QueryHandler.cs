using DatabaseServices.Repositories;
using Models.DTO.BackToFront.Full;
using Utils.CQRS;
using static Models.Entities.ValidationErrors.AuthorErrors;

namespace AdminAPI.Features.Authors.Get.ById;

public class QueryHandler : IQueryHandler<Query, AuthorFull>
{
    private readonly IAuthorRepository _authorRepository;

    public QueryHandler(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }

    public async Task<Result<AuthorFull>> Handle(Query request, CancellationToken cancellationToken)
    {
        var author = await _authorRepository.GetByIdAsync(request.Id);
        return author is null ?
            new Result<AuthorFull>(AuthorNotFound) :
            new Result<AuthorFull>(new AuthorFull(author));
    }
}