﻿using Models;

namespace Database.Services.Accessors.Interfaces;

public interface IDbAlbumAccessor
{
    public Task Add(Album album);
    Task<Album?> GetById(string id);
    Task<Album?> GetByName(string name);
}