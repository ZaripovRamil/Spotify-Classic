using AdminAPI.Dto;
using DatabaseServices.Repositories;
using Utils.CQRS;
using static Models.ValidationErrors.CommonConstants;

namespace AdminAPI.Features.Authors.Delete;

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
        await _authorRepository.DeleteAsync(author!);
        return new ResultDto(true, Successful);
    }
}