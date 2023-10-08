using Microsoft.EntityFrameworkCore;

namespace Models.Entities;

[PrimaryKey("Id")]
public class SupportChatMessage
{
    public string Id { get; set; } = default!;
    public User Sender { get; set; } = default!;
    public string SenderId { get; set; } = default!;
    public string RoomId { get; set; } = default!;
    public DateTime Timestamp { get; set; }
    public string Message { get; set; } = default!;
    public bool IsOwner { get; set; }
}