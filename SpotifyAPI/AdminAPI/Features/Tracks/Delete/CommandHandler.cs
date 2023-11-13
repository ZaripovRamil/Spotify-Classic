using AdminAPI.Dto;
using DatabaseServices.Repositories;
using Utils.CQRS;

namespace AdminAPI.Features.Tracks.Delete;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly ITrackRepository _trackRepository;

    public CommandHandler(ITrackRepository trackRepository)
    {
        _trackRepository = trackRepository;
    }

    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        var album = await _trackRepository.GetByIdAsync(request.Id);
        await _trackRepository.DeleteAsync(album!);
        return new ResultDto(true, "Successful");
    }
}