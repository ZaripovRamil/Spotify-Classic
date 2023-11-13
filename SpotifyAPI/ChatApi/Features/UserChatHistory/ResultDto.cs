using Models.DTO.FrontToBack.Chat;

namespace ChatApi.Features.UserChatHistory;

public record ResultDto(List<ChatMessage> Messages);