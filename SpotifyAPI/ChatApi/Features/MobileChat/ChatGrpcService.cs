using ChatApi.Chat;
using ChatApi.Dto;
using ChatApi.Extensions.Mappings;
using ChatApi.Features.AddMessageToHistory;
using DatabaseServices.Repositories;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace ChatApi.Features.MobileChat;

[Authorize]
public class ChatGrpcService : global::Chat.ChatBase
{
    private readonly ISupportChatHistoryRepository _historyRepository;
    private readonly IMediator _mediator;

    public ChatGrpcService(ISupportChatHistoryRepository historyRepository, IMediator mediator)
    {
        _historyRepository = historyRepository;
        _mediator = mediator;
    }

    public override async Task<ChatHistory> JoinChat(Empty request, ServerCallContext context)
    {
        var groupName = context.GetHttpContext().User.Identity!.Name;
        var messages = await _historyRepository
            .GetHistoryForUserId(groupName!)
            .AsAsyncEnumerable()
            .Select(sm => sm.MapToChatResponse())
            .OrderBy(m => m.Timestamp)
            .ToListAsync();

        var history = new ChatHistory();
        history.Messages.AddRange(messages);
        return history;
    }

    public override async Task StartReceivingMessages(Empty request,
        IServerStreamWriter<ChatMessageResponse> responseStream, ServerCallContext context)
    {
        var username = context.GetHttpContext().User.Identity!.Name;
        var connectionId = Guid.NewGuid();
        var listener = new GrpcListener(connectionId);
        ChatHub.RegisterListener(username!, listener);
        while (!context.CancellationToken.IsCancellationRequested)
        {
            foreach (var message in listener.ReadMessages())
            {
                await responseStream.WriteAsync(message.MapToChatResponse(), context.CancellationToken);
            }
        }
        
        ChatHub.UnsubscribeListener(username!, listener);
    }

    public override async Task<Empty> SendChatMessage(ChatMessageRequest request, ServerCallContext context)
    {
        await SaveToChatHistory(request, context);
        ChatHub.SendGroupMessage(MapToChatMessage(request, context));
        return new Empty();
    }

    private async Task SaveToChatHistory(ChatMessageRequest request, ServerCallContext context)
    {
        var userId = context.GetHttpContext().User.Claims.First(c => c.Type == "Id").Value;
        var command = new Command(userId, MapToChatMessage(request, context));
        await _mediator.Send(command);
    }

    private static ChatMessage MapToChatMessage(ChatMessageRequest request, ServerCallContext context)
    {
        var username = context.GetHttpContext().User.Identity!.Name;
        
        return new ChatMessage
        {
            Message = request.Content,
            GroupName = username!,
            IsOwner = true,
            Timestamp = DateTime.UtcNow,
            User = username!
        };
    }
}