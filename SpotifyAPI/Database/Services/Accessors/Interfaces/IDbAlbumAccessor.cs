﻿using Models.DTO.BackToFront.Light;
using Models.Entities;

namespace Database.Services.Accessors.Interfaces;

public interface IDbAlbumAccessor
{
    public Task Add(Album album);
    Task<Album?> GetById(string id);
    Task<Album?> GetByName(string name);
    IEnumerable<Album> GetAll();
}