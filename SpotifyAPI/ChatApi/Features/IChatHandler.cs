using ChatApi.Dto;

namespace ChatApi.Features;

public interface IChatHandler
{
    public Task ConsumeMessage(ChatMessage message);
}