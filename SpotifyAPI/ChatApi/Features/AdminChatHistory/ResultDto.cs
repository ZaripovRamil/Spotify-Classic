using ChatApi.Dto;

namespace ChatApi.Features.AdminChatHistory;

public record ResultDto(List<ChatMessage> Messages);
