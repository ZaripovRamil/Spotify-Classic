using DatabaseServices.Repositories;
using Utils.CQRS;

namespace AdminAPI.Features.Albums.Create;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly IAlbumRepository _albumRepository;
    private readonly IEnumerable<ISaver<Command>> _savers;

    public CommandHandler(IAlbumRepository albumRepository, IEnumerable<ISaver<Command>> savers)
    {
        _albumRepository = albumRepository;
        _savers = savers;
    }

    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        var res =_savers.Select(async s => await s.SaveAsync(request)).ToArray();
        await Task.WhenAll(res);
        if (res.Any(r => !r.Result.IsSuccessful))
        {
            await Task.WhenAll(_savers.Select(async s => await s.UnSaveAsync(request)));
            return new ResultDto(false, string.Join('\n', res.SelectMany(r => r.Result.Errors)), null);
        }

        var album = await _albumRepository.FilterAsync(a => a.PreviewId == request.PreviewId.ToString())
            .FirstOrDefaultAsync(cancellationToken: cancellationToken);
        return new ResultDto(true, "Successful", album!.Id);
    }
}