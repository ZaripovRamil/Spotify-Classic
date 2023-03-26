using Models;
using Models.DTO.FrontToBack.EntityCreationData;

namespace Database.Services.Factories.Interfaces;

public interface IAlbumFactory
{
    public Task<Album?> Create(AlbumCreationData pData);
}