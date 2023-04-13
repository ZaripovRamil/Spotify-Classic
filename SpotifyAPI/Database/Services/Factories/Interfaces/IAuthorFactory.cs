using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Services.Factories.Interfaces;

public interface IAuthorFactory
{
    public Task<(AuthorCreationCode, Author?)> Create(AuthorCreationData data);
}