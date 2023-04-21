using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace Database.Services.Factories.Interfaces;

public interface IGenreFactory
{
    public Task<(GenreValidationCode, Genre?)> Create(GenreCreationData data);
}