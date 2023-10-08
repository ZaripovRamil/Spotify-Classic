using DatabaseServices.Services.Accessors.Interfaces;
using MassTransit;
using Models.MessagingContracts;

namespace ChatApi.Consumers;

public class SupportChatHistorySaverConsumer : IConsumer<SaveHistoryMessageToDb>
{
    private readonly IDbSupportChatHistoryAccessor _historyAccessor;

    public SupportChatHistorySaverConsumer(IDbSupportChatHistoryAccessor historyAccessor)
    {
        _historyAccessor = historyAccessor;
    }

    public async Task Consume(ConsumeContext<SaveHistoryMessageToDb> context)
    {
        await _historyAccessor.AddMessageToUserHistory(context.Message.Message);
    }
}