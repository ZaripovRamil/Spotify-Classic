using DatabaseServices.Repositories;
using Models.Entities;
using Utils.CQRS;

namespace AdminAPI.Features.Authors.Create;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly IAuthorRepository _authorRepository;

    public CommandHandler(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }

    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        var author = new Author(request.UserId, request.Name);
        await _authorRepository.AddAsync(author);
        return new ResultDto(true, "Successful", author.Id);
    }
}