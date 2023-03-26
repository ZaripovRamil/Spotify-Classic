using Database.Services.Factories.Interfaces;
using Models;
using Models.DTO.FrontToBack.EntityCreationData;

namespace Database.Services.Factories.Implementations;

public class AlbumFactory:IAlbumFactory
{
    public Task<Album?> Create(AlbumCreationData pData)
    {
        throw new NotImplementedException();
    }
}