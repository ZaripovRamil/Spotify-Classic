﻿using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Services.Factories.Interfaces;

public interface IPlaylistFactory
{
    public Task<(PlaylistCreationCode, Playlist?)> Create(PlaylistCreationData data);
}