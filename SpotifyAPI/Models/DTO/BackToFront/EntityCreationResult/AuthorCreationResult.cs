﻿using Models.Entities;

namespace Models.DTO.BackToFront.EntityCreationResult;

public class AuthorCreationResult
{
    private static readonly Dictionary<AuthorCreationCode, string> Messages = new()
    {
        {AuthorCreationCode.Successful, "Success"},
        {AuthorCreationCode.InvalidUser, "Invalid UserId"},
        {AuthorCreationCode.UnknownError, "Unknown error"}
    };

    public bool IsSuccessful { get; set; }
    public string? AuthorId { get; set; }
    public string ResultMessage { get; set; }

    public AuthorCreationResult(AuthorCreationCode code, Author? author)
    {
        IsSuccessful = code == AuthorCreationCode.Successful;
        ResultMessage = Messages[code];
        AuthorId = author?.Id;
    }

    public AuthorCreationResult((AuthorCreationCode State, Author? Author) data) : this(data.State, data.Author)
    {
    }
}