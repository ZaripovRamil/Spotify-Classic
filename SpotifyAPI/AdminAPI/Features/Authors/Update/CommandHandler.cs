using AdminAPI.Dto;
using DatabaseServices.Repositories;
using Utils.CQRS;

namespace AdminAPI.Features.Authors.Update;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly IAuthorRepository _authorRepository;

    public CommandHandler(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }

    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        var author = await _authorRepository.GetByIdAsync(request.Id);
        author!.Name = request.Name;
        await _authorRepository.UpdateAsync(author);
        return new ResultDto(true, "Successful");
    }
}