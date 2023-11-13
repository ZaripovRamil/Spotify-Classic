using AdminAPI.Features.Tracks.Create.TracksSavers;
using AdminAPI.Services;
using Utils.CQRS;

namespace AdminAPI.Features.Tracks.Create;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly IEnumerable<ISaver<Command, string>> _savers;

    public CommandHandler(IEnumerable<ISaver<Command, string>> savers)
    {
        _savers = savers;
    }

    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        Result<string>? trackIdResult = null;
        var res =_savers.Select(async s =>
        {
            if (s is not DbInfoSaver) return await s.SaveAsync(request);
            return trackIdResult = await s.SaveAsync(request);
        }).ToArray();
        
        await Task.WhenAll(res);
        if (!Array.Exists(res, r => !r.Result.IsSuccessful))
            return new ResultDto(true, "Successful", trackIdResult!.Value);
        
        await Task.WhenAll(_savers.Select(async s => await s.UnSaveAsync(request)));
        return new ResultDto(false, string.Join('\n', res.SelectMany(r => r.Result.Errors)), null);
    }
}