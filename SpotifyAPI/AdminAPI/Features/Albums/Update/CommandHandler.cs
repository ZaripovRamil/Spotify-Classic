using AdminAPI.Dto;
using DatabaseServices.Repositories;
using Utils.CQRS;

namespace AdminAPI.Features.Albums.Update;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly IAlbumRepository _albumRepository;

    public CommandHandler(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        var album = await _albumRepository.GetByIdAsync(request.Id);
        album!.Name = request.Name;
        await _albumRepository.UpdateAsync(album);
        return new ResultDto(true, "Successful");
    }
}