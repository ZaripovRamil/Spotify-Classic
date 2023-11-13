using AdminAPI.Dto;
using DatabaseServices.Repositories;
using Utils.CQRS;

namespace AdminAPI.Features.Tracks.Update;

public class CommandHandler : ICommandHandler<Command, ResultDto>
{
    private readonly ITrackRepository _trackRepository;

    public CommandHandler(ITrackRepository trackRepository)
    {
        _trackRepository = trackRepository;
    }

    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        var track = await _trackRepository.GetByIdAsync(request.Id);
        track!.Name = request.Name;
        await _trackRepository.UpdateAsync(track);
        return new ResultDto(true, "Successful");
    }
}