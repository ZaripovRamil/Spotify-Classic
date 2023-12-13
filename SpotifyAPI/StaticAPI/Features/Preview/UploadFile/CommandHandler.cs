
using System.Text.Json;
using Models.Metadata;
using StaticAPI.Dto;
using StaticAPI.Services;
using Utils.CQRS;
using static StaticAPI.Constants.S3Storage;

namespace StaticAPI.Features.Preview.UploadFile;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly IStorage _storage;

    public CommandHandler(IStorage fp)
    {
        _storage = fp;
    }
    
    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        
        if (request.Data.File is null || request.Data.File.Length == 0)
            return new Result<ResultDto>("Empty file");
        if (request.Data.File.FileName.Length == 0)
            return new Result<ResultDto>("Filename is not provided");
        
        if(request.Data.ImageMetadata is null)
            return new Result<ResultDto>("Empty metadata");
        
        await _storage.UploadAsync(PreviewsBucketName, request.Data.File.FileName, request.Data.File.OpenReadStream(),
            cancellationToken);
        return new ResultDto(true, "Successful");
    }
}