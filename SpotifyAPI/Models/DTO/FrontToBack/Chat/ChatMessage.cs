namespace Models.DTO.FrontToBack.Chat;

public class ChatMessage
{
    public string GroupName { get; set; } = default!;
    public string User { get; set; } = default!;
    public DateTime Timestamp { get; set; } = default!;
    public string Message { get; set; } = default!;
    public bool IsOwner { get; set; }
    
    
}