using MassTransit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Models.DTO.FrontToBack.Chat;
using Models.Entities;
using Models.MessagingContracts;

namespace ChatApi.Chat;

[Authorize]
public class ChatHub : Hub
{
    private static readonly Dictionary<string,string> ActiveAdminConnections = new();
    private static readonly List<string> ConnectedAdminGroups= new();
    private readonly IBus _bus;

    public ChatHub(IBus bus)
    {
        _bus = bus;
    }

    public async Task SendMessage(ChatMessage message)
    {
        var username = Context.User!.Identity!.Name;
        message.User = username!;
        message.IsOwner = true;
        
        await AddMessageToHistory(username!,message);

        await Clients.Client(Context.ConnectionId).SendAsync("ReceiveMessage", message);
        await Clients.GroupExcept(username!,Context.ConnectionId).SendAsync("ReceiveMessage", message);
    }

    public async Task AddToGroup()
    {
        var username = Context.User!.Identity!.Name;
        await Groups.AddToGroupAsync(Context.ConnectionId, username!);
    }

    [Authorize(Roles = "Admin")]
    public async Task SendAdminMessage(ChatMessage message)
    {
        message.User = "Admin";
        message.IsOwner = false;
        var groupname = message.GroupName;
        
        await AddMessageToHistory(groupname,message);

        await Clients.Client(Context.ConnectionId).SendAsync("ReceiveMessage", message);
        await Clients.GroupExcept(groupname,Context.ConnectionId).SendAsync("ReceiveMessage", message);
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
        await Groups.AddToGroupAsync(Context.ConnectionId, groupname);
    }

    private async Task AddMessageToHistory(string groupname, ChatMessage message)
    {
        var userId = Context.User?.Claims.First(c => c.Type == "Id").Value;
        if (userId is null) return;
        var sm = new SupportChatMessage
        {
            Id = Guid.NewGuid().ToString(),
            RoomId = groupname,
            IsOwner = message.IsOwner,
            Message = message.Message,
            Timestamp = DateTime.UtcNow,
            SenderId = userId
        };
        await _bus.Publish(new SaveHistoryMessageToDb { Message = sm });
    }
}