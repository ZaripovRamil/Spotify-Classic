using DatabaseServices.Services.Repositories.Implementations;
using MassTransit;
using Models.MessagingContracts;

namespace ChatHistorySaverService.Consumers;

public class ChatHistoryMessagesConsumer : IConsumer<SaveHistoryMessageToDb>
{
    private readonly IDbSupportChatHistoryRepository _historyRepository;

    public ChatHistoryMessagesConsumer(IDbSupportChatHistoryRepository historyRepository)
    {
        _historyRepository = historyRepository;
    }

    public async Task Consume(ConsumeContext<SaveHistoryMessageToDb> context)
    {
        await _historyRepository.AddMessageToUserHistoryAsync(context.Message.Message);
    }
}