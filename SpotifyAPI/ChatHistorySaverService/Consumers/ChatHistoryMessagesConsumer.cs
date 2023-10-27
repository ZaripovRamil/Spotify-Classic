using DatabaseServices.Services.Accessors.Interfaces;
using MassTransit;
using Models.MessagingContracts;

namespace ChatHistorySaverService.Consumers;

public class ChatHistoryMessagesConsumer : IConsumer<SaveHistoryMessageToDb>
{
    private readonly IDbSupportChatHistoryAccessor _historyAccessor;

    public ChatHistoryMessagesConsumer(IDbSupportChatHistoryAccessor historyAccessor)
    {
        _historyAccessor = historyAccessor;
    }

    public async Task Consume(ConsumeContext<SaveHistoryMessageToDb> context)
    {
        await _historyAccessor.AddMessageToUserHistory(context.Message.Message);
    }
}