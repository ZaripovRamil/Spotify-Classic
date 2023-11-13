using ChatApi.Features.AddMessageToHistory;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Models.DTO.FrontToBack.Chat;

namespace ChatApi.Chat;

[Authorize]
public class ChatHub : Hub
{
    private static readonly Dictionary<string,string> ActiveAdminConnections = new();
    private static readonly List<string> ConnectedAdminGroups= new();
    
    private readonly IMediator _mediator;

    public ChatHub(IMediator mediator)
    {
        _mediator = mediator;
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

        if (res.IsSuccessful)
        {
            await Clients.Client(Context.ConnectionId).SendAsync("ReceiveMessage", message);
            await Clients.GroupExcept(groupName,Context.ConnectionId).SendAsync("ReceiveMessage", message);
        }
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

        if (res.IsSuccessful)
        {
            await Clients.Client(Context.ConnectionId).SendAsync("ReceiveMessage", message);
            await Clients.GroupExcept(message.GroupName,Context.ConnectionId).SendAsync("ReceiveMessage", message);
        }
    }

    public async Task AddToGroup()
    {
        var username = Context.User!.Identity!.Name;
        await Groups.AddToGroupAsync(Context.ConnectionId, username!);
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
}