using AdminAPI.Services;
using Utils.CQRS;
using static Models.ValidationErrors.CommonConstants;

namespace AdminAPI.Features.Albums.Create;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly IEnumerable<ISaver<Command, string>> _savers;

    public CommandHandler(IEnumerable<ISaver<Command, string>> savers)
    {
        _savers = savers;
    }

    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        var prepare = _savers.Select(s => s.PrepareAsync(request)).ToArray();
        var prepResults = await Task.WhenAll(prepare);
        if (Array.Exists(prepResults, r => !r.IsSuccessful))
        {
            await Task.WhenAll(_savers.Select(async s => await s.UnPrepareAsync(request)));
            return new Result<ResultDto>(errors: string.Join('\n', prepResults.SelectMany(r => r.Errors)));
        }

        var res =_savers.Select(s => s.SaveAsync(request)).ToArray();
        
        var commitResults = await Task.WhenAll(res);
        if (!Array.Exists(commitResults, r => !r.IsSuccessful))
            return new ResultDto(true, Successful, request.Id);
        
        await Task.WhenAll(_savers.Select(async s => await s.UnSaveAsync(request)));
        return new ResultDto(false, string.Join('\n', res.SelectMany(r => r.Result.Errors)), null);
    }
}