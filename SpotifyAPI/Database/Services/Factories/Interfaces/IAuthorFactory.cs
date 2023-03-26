using Models;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Services.Factories.Interfaces;

public interface IAuthorFactory
{
    public Task<Author?> Create(AuthorCreationData pData);
}