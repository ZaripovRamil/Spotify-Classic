﻿using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace DatabaseServices.Services.Factories.Interfaces;

public interface IPlaylistFactory
{
    public Task<(PlaylistValidationCode, Playlist?)> Create(PlaylistCreationData data);
}