using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace Database.Services.Factories.Interfaces;

public interface IAlbumFactory
{
    public Task<(AlbumValidationCode, Album?)> Create(AlbumCreationData data);
}