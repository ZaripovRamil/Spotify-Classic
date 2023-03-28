﻿using Models;

namespace Database.Services.Accessors.Interfaces;

public interface IDbPlaylistAccessor
{
    public Task Add(Playlist playlist);
    public Task<Playlist?> Get(string id);
}