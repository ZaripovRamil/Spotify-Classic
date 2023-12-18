using StaticAPI.Dto;
using StaticAPI.Services;
using Utils.CQRS;
using static StaticAPI.Constants.S3Storage;

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
        if (request.Data is null)
            return new Result<ResultDto>("Empty data");
        var file = request.Data.File;
        if (file is null || file.Length == 0)
            return new Result<ResultDto>("Empty file");
        if (file.FileName.Length == 0)
            return new Result<ResultDto>("Filename is not provided");
        
        if(request.Data.TrackMetadata is null)
            return new Result<ResultDto>("Empty metadata");
        
        await _fileUploader.UploadFileAsync(request.Data.File, request.Data.TrackMetadata,
            cancellationToken);

        return new ResultDto(true,"Successful");
    }
}