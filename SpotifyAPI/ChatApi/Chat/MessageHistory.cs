using Models.DTO.FrontToBack.Chat;

namespace ChatApi.Chat;

public static class ChatService
{
    public static Dictionary<string,List<ChatMessage>> MessageHistory = new Dictionary<string,List<ChatMessage>>();
}