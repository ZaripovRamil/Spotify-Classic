using ChatApi.Dto;
using MassTransit;
using Models.Entities;
using Models.MessagingContracts;
using Utils.CQRS;
using static Models.ValidationErrors.CommonConstants;

namespace ChatApi.Features.AddMessageToHistory;

public class CommandHandler : ICommandHandler<Command,ResultDto>
{
    private readonly IBus _bus;

    public CommandHandler(IBus bus)
    {
        _bus = bus;
    }
    
    public async Task<Result<ResultDto>> Handle(Command request, CancellationToken cancellationToken)
    {
        var sm = new SupportChatMessage(request.UserId, request.Message.GroupName, DateTime.UtcNow,
            request.Message.Message, request.Message.IsOwner);
        await _bus.Publish(new SaveHistoryMessageToDb { Message = sm }, cancellationToken);
        return new ResultDto(true, Successful);
    }
    
}