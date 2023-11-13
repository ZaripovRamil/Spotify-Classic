using Models.DTO.FrontToBack.Chat;

namespace ChatApi.Features.AdminChatHistory;

public record ResultDto(List<ChatMessage> Messages);
