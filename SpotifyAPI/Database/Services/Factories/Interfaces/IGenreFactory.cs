using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Services.Factories.Interfaces;

public interface IGenreFactory
{
    public Task<(GenreCreationCode, Genre?)> Create(GenreCreationData data);
}