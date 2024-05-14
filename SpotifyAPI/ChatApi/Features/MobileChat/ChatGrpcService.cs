using ChatApi.Chat;
using ChatApi.Dto;
using ChatApi.Features.AddMessageToHistory;
using DatabaseServices.Repositories;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using MediatR;
using Microsoft.AspNetCore.Authorization;

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

    public override Task<ChatHistory> JoinChat(Empty request, ServerCallContext context)
    {
        var groupName = context.GetHttpContext().User.Identity!.Name;

        return Task.FromResult(new ChatHistory
        {
            Messages =
            {
                _historyRepository
                    .GetHistoryForUserId(groupName!)
                    .Select(sm => new ChatMessageResponse
                    {
                        Content = sm.Message,
                        IsOwner = sm.IsOwner,
                        Timestamp = sm.Timestamp.ToTimestamp(),
                        User = sm.Sender.Name
                    })
                    .OrderBy(m => m.Timestamp)
            }
        });
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
                await responseStream.WriteAsync(MapToChatResponse(message), context.CancellationToken);
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

    private static ChatMessageResponse MapToChatResponse(ChatMessage message)
    {
        return new ChatMessageResponse
        {
            User = message.User,
            Content = message.Message,
            Timestamp = message.Timestamp.ToTimestamp(),
            IsOwner = message.IsOwner
        };
    }

    private async Task SaveToChatHistory(ChatMessageRequest request, ServerCallContext context)
    {
        var userId = context.GetHttpContext().User.Claims.First(c => c.Type == "Id").Value;
        var username = context.GetHttpContext().User.Identity!.Name;
        var command = new Command(userId, new ChatMessage
        {
            Message = request.Content,
            Timestamp = DateTime.UtcNow,
            User = username!,
            IsOwner = true,
            GroupName = username!
        });
        await _mediator.Send(command);
    }
}