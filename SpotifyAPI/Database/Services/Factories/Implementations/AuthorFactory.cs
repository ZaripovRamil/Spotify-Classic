using Database.Services.Accessors.Interfaces;
using Database.Services.Factories.Interfaces;
using Models;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Services.Factories.Implementations;

public class AuthorFactory:IAuthorFactory
{
    private readonly IDbUserAccessor _userAccessor;

    public AuthorFactory(IDbUserAccessor userAccessor)
    {
        _userAccessor = userAccessor;
    }

    public async Task<Author?> Create(AuthorCreationData pData)
    {
        var owner = await _userAccessor.GetById(pData.UserId);
        return owner == null ? null : new Author();
    }
}