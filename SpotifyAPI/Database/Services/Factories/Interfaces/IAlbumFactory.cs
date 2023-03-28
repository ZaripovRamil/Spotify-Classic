using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Services.Factories.Interfaces;

public interface IAlbumFactory
{
    public Task<Album?> Create(AlbumCreationData pData);
}