using ChatApi.Dto;
using Utils.CQRS;

namespace ChatApi.Features.AddMessageToHistory;

public record Command(string UserId, ChatMessage Message): ICommand<ResultDto>;