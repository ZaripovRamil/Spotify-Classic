using ChatApi.Dto;
using Models.DTO.FrontToBack.Chat;
using Utils.CQRS;

namespace ChatApi.Features.AddMessageToHistory;

public record Command(string UserId, ChatMessage Message): ICommand<ResultDto>;