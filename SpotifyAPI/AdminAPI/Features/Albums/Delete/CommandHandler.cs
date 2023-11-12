using AdminAPI.Dto;
using DatabaseServices.Repositories;
using Utils.CQRS;

namespace AdminAPI.Features.Albums.Delete;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly IAlbumRepository _albumRepository;

    public CommandHandler(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        var album = await _albumRepository.GetByIdAsync(request.Id.ToString());
        await _albumRepository.DeleteAsync(album!);
        return new ResultDto(true, "Successful");
    }
}