using ChatApi.Dto;

namespace ChatApi.Features;

public interface IChatListener
{
    public Task ConsumeMessage(ChatMessage message);
}