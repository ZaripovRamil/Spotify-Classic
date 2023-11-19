using StaticAPI.Dto;
using StaticAPI.Services;
using Utils.CQRS;
using static StaticAPI.Constants.S3Storage;

namespace StaticAPI.Features.Track.UploadTrack;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly IStorage _storage;

    public CommandHandler(IStorage fp)
    {
        _storage = fp;
    }
    
    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        var file = request.File;
        if (file is null || file.Length == 0)
            return new Result<ResultDto>("Empty file");
        if (file.FileName.Length == 0)
            return new Result<ResultDto>("Filename is not provided");
        
        await _storage.UploadAsync(TracksPendingBucketName, file.FileName, file.OpenReadStream(),
            cancellationToken);

        return new ResultDto(true,"Successful");
    }
}