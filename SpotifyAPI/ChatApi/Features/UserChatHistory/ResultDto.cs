using ChatApi.Dto;

namespace ChatApi.Features.UserChatHistory;

public record ResultDto(List<ChatMessage> Messages);