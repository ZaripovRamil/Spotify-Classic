﻿using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace Models.DTO.InterServices.ValidationResult;

public class PlaylistValidationResult:EntityValidationResult
{
    public PlaylistValidationResult(PlaylistValidationCode code, User user) : base((int)code)
    {
        Owner = user;
    }

    public User Owner { get; set; }
}