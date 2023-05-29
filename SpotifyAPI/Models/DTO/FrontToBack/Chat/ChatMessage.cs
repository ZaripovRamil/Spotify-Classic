﻿namespace Models.DTO.FrontToBack.Chat;

public class ChatMessage
{
    public string GroupName { get; set; }
    public string User { get; set; }

    public string Message { get; set; }
    public bool IsOwner { get; set; }
}