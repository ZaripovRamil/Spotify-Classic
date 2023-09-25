using Models.DTO.FrontToBack.Chat;

namespace ChatApi.Chat;

internal static class ChatService
{
    public static readonly Dictionary<string, List<ChatMessage>> MessageHistory = new();
}