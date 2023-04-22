using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace DatabaseServices.Services.Factories.Interfaces;

public interface IAuthorFactory
{
    public Task<(AuthorValidationCode, Author?)> Create(AuthorCreationData data);
}