using StaticAPI.Dto;
using StaticAPI.Services.Interfaces;
using Utils.CQRS;
using static Models.ValidationErrors.CommonConstants;

namespace StaticAPI.Features.Track.UploadTrack;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly IFileUploader _fileUploader;

    public CommandHandler(IFileUploader fileUploader)
    {
        _fileUploader = fileUploader;
    }
    
    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        var file = request.Data!.File;
        await _fileUploader.UploadFileAsync(file!, request.Data.TrackMetadata!,
            cancellationToken);
        return new ResultDto(true,Successful);
    }
}