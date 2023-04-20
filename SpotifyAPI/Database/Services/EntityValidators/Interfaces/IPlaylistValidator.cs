﻿using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.ValidationResult;

namespace Database.Services.EntityValidators.Interfaces;

public interface IPlaylistValidator
{
    public PlaylistValidationResult Validate(PlaylistCreationData data);
}