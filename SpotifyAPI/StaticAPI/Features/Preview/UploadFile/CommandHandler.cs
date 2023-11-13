
using StaticAPI.Dto;
using StaticAPI.Services;
using Utils.CQRS;

namespace StaticAPI.Features.Preview.UploadFile;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly IFileProvider _fileProvider;

    public CommandHandler(IFileProvider fp)
    {
        _fileProvider = fp;
    }
    
    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        if (request.File is null || request.File.Length == 0)
            return new Result<ResultDto>("Empty file");
        if (request.File.FileName.Length == 0)
            return new Result<ResultDto>("Filename is not provided");
        await _fileProvider.UploadAsync("Previews", request.File.FileName, request.File.OpenReadStream());
        return new ResultDto(true, "Successful");
    }
}