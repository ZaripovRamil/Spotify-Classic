using StaticAPI.Dto;
using StaticAPI.Services;
using Utils.CQRS;

namespace StaticAPI.Features.Track.UploadTrack;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private const string AssetsName = "Assets";
    private readonly IFileProvider _fileProvider;
    private readonly IHlsConverter _hlsConverter;
    
    public CommandHandler(IFileProvider fp, IHlsConverter hlsConverter)
    {
        _fileProvider = fp;
        _hlsConverter = hlsConverter;
    }
    
    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        var file = request.File;
        if (file is null || file.Length == 0)
            return new Result<ResultDto>("Empty file");
        if (file.FileName.Length == 0)
            return new Result<ResultDto>("Filename is not provided");
        var fileName = Path.GetFileNameWithoutExtension(file.FileName);
        var trackPath = Path.Combine("Tracks", fileName);
        await _fileProvider.UploadAsync(trackPath, file.FileName, file.OpenReadStream());
        if (!file.FileName.EndsWith(".mp3")) return new ResultDto(true,"Successfull");
        await _hlsConverter.SaveHlsFromMp3Async(Path.Combine(AssetsName, "Tracks", fileName, file.FileName),
            Path.Combine(AssetsName, trackPath));
        await _fileProvider.DeleteFileAsync(trackPath, file.FileName);

        return new ResultDto(true,"Successfull");
    }
}