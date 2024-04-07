using AdminAPI.Features.Tracks.Create.TracksSavers;
using AdminAPI.Services;
using Utils.CQRS;
using static Models.ValidationErrors.CommonConstants;

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
        
        var dbSaver =  _savers.FirstOrDefault(s => s is DbInfoSaver);
        if (dbSaver is not null)
            trackIdResult = await dbSaver.SaveAsync(request);
        
        if (!trackIdResult!.IsSuccessful)
            return new ResultDto(false, string.Join('\n', trackIdResult.Errors), null);

        request = request with { TrackId = trackIdResult.Value };
        
        var res = _savers.Where(s => s is not DbInfoSaver)
            .Select(async s => await s.SaveAsync(request)).ToArray();
        
        await Task.WhenAll(res);
        if (!Array.Exists(res, r => !r.Result.IsSuccessful))
                return new ResultDto(true, Successful, trackIdResult.Value);
            
        await Task.WhenAll(_savers.Select(async s => await s.UnSaveAsync(request)));
        return new ResultDto(false, string.Join('\n', res.SelectMany(r => r.Result.Errors)), null);
    }
}