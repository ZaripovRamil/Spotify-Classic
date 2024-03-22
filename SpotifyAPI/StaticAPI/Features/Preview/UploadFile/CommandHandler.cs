using StaticAPI.Dto;
using StaticAPI.Services;
using Utils.CQRS;
using static Models.ValidationErrors.CommonConstants;

namespace StaticAPI.Features.Preview.UploadFile;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly IFileUploader _fileUploader;

    public CommandHandler(IFileUploader fileUploader)
    {
        _fileUploader = fileUploader;
    }

    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        await _fileUploader.UploadFileAsync(request.Data!.File!, request.Data.ImageMetadata!, cancellationToken);
        return new ResultDto(true, Successful);
    }
}