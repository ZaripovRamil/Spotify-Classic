using ChatApi.Dto;
using Google.Protobuf.WellKnownTypes;
using Models.Entities;

namespace ChatApi.Extensions.Mappings;

public static class Chat
{
    public static ChatMessageResponse MapToChatResponse(this ChatMessage message)
    {
        return new ChatMessageResponse
        {
            User = message.User,
            Content = message.Message,
            Timestamp = message.Timestamp.ToTimestamp(),
            IsOwner = message.IsOwner
        };
    }

    public static ChatMessageResponse MapToChatResponse(this SupportChatMessage message)
    {
        return new ChatMessageResponse
        {
            Content = message.Message,
            IsOwner = message.IsOwner,
            Timestamp = message.Timestamp.ToTimestamp(),
            User = message.Sender.Name
        };
    }
}