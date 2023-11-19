using StaticAPI.Dto;
using StaticAPI.Services;
using Utils.CQRS;
using static StaticAPI.Constants.S3Storage;

namespace StaticAPI.Features.Track.UploadTrack;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly IFileProvider _fileProvider;

    public CommandHandler(IFileProvider fp)
    {
        _fileProvider = fp;
    }
    
    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        var file = request.File;
        if (file is null || file.Length == 0)
            return new Result<ResultDto>("Empty file");
        if (file.FileName.Length == 0)
            return new Result<ResultDto>("Filename is not provided");
        
        await _fileProvider.UploadAsync(TracksPendingBucketName, file.FileName, file.OpenReadStream(),
            cancellationToken);

        return new ResultDto(true,"Successful");
    }
}