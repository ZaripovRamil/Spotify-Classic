using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Services.Factories.Interfaces;

public interface IAlbumFactory
{
    public Task<(AlbumCreationCode, Album?)> Create(AlbumCreationData data);
}