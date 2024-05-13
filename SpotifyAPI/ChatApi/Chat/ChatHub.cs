﻿using ChatApi.Dto;
using ChatApi.Features;
using ChatApi.Features.AddMessageToHistory;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace ChatApi.Chat;

[Authorize]
public class ChatHub : Hub
{
    private static readonly Dictionary<string,string> ActiveAdminConnections = new();
    private static readonly List<string> ConnectedAdminGroups = new();
    private static readonly Dictionary<string, List<IChatHandler>> Listeners = new();
    
    private readonly IMediator _mediator;

    public ChatHub(IMediator mediator)
    {
        _mediator = mediator;
    }

    public static void RegisterListener(string group, IChatHandler listener)
    {
        if (!Listeners.ContainsKey(group)) Listeners[group] = new List<IChatHandler>();
        Listeners[group].Add(listener);
    }

    public static void SendGroupMessage(ChatMessage message)
    {
        Parallel.ForEach(Listeners[message.GroupName], listener =>
        {
            try
            {
                listener.ConsumeMessage(message);
            }
            catch (Exception)
            {
                // ignored
            }
        });
    }

    public static void UnsubscribeListener(string group, IChatHandler listener)
    {
        if (!Listeners.ContainsKey(group)) return;
        Listeners[group].Remove(listener);
    }

    public async Task SendMessage(ChatMessage message)
    {
        var userId = Context.User?.Claims.First(c => c.Type == "Id").Value;
        var groupName = Context.User!.Identity!.Name;
        if (userId is null || groupName is null) return;

        message.GroupName = message.User = groupName;
        message.IsOwner = true;

        var addMessageCommand = new Command(userId,message);
        var res = await _mediator.Send(addMessageCommand);

        if (res.IsSuccessful) SendGroupMessage(message);
    }
    
    [Authorize(Roles = "Admin")]
    public async Task SendAdminMessage(ChatMessage message)
    {
        var userId = Context.User?.Claims.First(c => c.Type == "Id").Value;
        if (userId is null) return;
        
        message.IsOwner = false;
        message.User = "Admin";
        
        var addMessageCommand = new Command(userId, message);
        var res = await _mediator.Send(addMessageCommand);

        if (res.IsSuccessful) SendGroupMessage(message);
    }

    public Task AddToGroup()
    {
        var username = Context.User!.Identity!.Name;
        RegisterListener(username!, new SignalRListener(Clients.Client(Context.ConnectionId), Context.ConnectionId));
        return Task.CompletedTask;
    }
    
    [Authorize(Roles = "Admin")]
    public async Task AddToGroupByName(string groupname)
    {
        foreach (var group in ConnectedAdminGroups)
        {
            await Groups.RemoveFromGroupAsync(ActiveAdminConnections[group], group);
        }
        ConnectedAdminGroups.Clear();
        ActiveAdminConnections[groupname] = Context.ConnectionId;
        ConnectedAdminGroups.Add(groupname);
        RegisterListener(groupname, new SignalRListener(Clients.Client(Context.ConnectionId), Context.ConnectionId));
    }
    
    public override Task OnDisconnectedAsync(Exception? exception)
    {
        var groupname = Context.User?.Identity?.Name;
        if (groupname is null) return Task.CompletedTask;
        UnsubscribeListener(groupname, new SignalRListener(Clients.Client(Context.ConnectionId), Context.ConnectionId));
        return base.OnDisconnectedAsync(exception);
    }
}

public class SignalRListener : IChatHandler
{
    public SignalRListener(ISingleClientProxy client, string connectionId)
    {
        _client = client;
        _connectionId = connectionId;
    }

    private readonly ISingleClientProxy _client;
    private readonly string _connectionId;
    
    public Task ConsumeMessage(ChatMessage message)
    {
        _client.SendAsync("ReceiveMessage", message);
        return Task.CompletedTask;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj is not SignalRListener listener) return false;
        return _connectionId == listener._connectionId;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_client, _connectionId);
    }
}