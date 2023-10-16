using Models.Entities;

namespace Models.MessagingContracts;

public class SaveHistoryMessageToDb
{
    public SupportChatMessage Message { get; init; } = default!;
}