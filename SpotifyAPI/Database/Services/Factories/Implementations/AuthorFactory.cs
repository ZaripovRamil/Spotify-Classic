using Database.Services.Accessors.Interfaces;
using Database.Services.Factories.Interfaces;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Services.Factories.Implementations;

public class AuthorFactory : IAuthorFactory
{
    private readonly IDbUserAccessor _userAccessor;

    public AuthorFactory(IDbUserAccessor userAccessor)
    {
        _userAccessor = userAccessor;
    }

    public async Task<Author?> Create(AuthorCreationData aData)
    {
        var owner = await _userAccessor.GetById(aData.UserId);
        return owner == null ? null : new Author(aData.Name, aData.UserId);
    }
}