﻿using Models.Entities;

namespace Models.DTO.BackToFront.EntityCreationResult;

public class RegistrationResult
{
    private static readonly Dictionary<RegistrationCode, string> Messages = new() {
        {RegistrationCode.Successful, "Success"},
        {RegistrationCode.EmailTaken, "Email is taken"},
        {RegistrationCode.LoginTaken, "Login is taken"},
        {RegistrationCode.WeakPassword, "Weak password"},
        {RegistrationCode.UnknownError, "Unknown error"}
    };
    public bool IsSuccessful { get; set; }
    public string? UserId { get; set; }
    public string ResultMessage { get; set; }

    public RegistrationResult(RegistrationCode code, User? user)
    {
        IsSuccessful = code == RegistrationCode.Successful;
        ResultMessage = Messages[code];
        UserId = user?.Id;
    }
}