using DatabaseServices.Repositories;
using MassTransit;
using Models.MessagingContracts;

namespace ChatHistorySaverService.Consumers;

public class ChatHistoryMessagesConsumer : IConsumer<SaveHistoryMessageToDb>
{
    private readonly ISupportChatHistoryRepository _historyRepository;

    public ChatHistoryMessagesConsumer(ISupportChatHistoryRepository historyRepository)
    {
        _historyRepository = historyRepository;
    }

    public async Task Consume(ConsumeContext<SaveHistoryMessageToDb> context)
    {
        await _historyRepository.AddAsync(context.Message.Message);
    }
}