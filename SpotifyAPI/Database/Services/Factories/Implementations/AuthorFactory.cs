using Database.Services.Accessors.Interfaces;
using Database.Services.Factories.Interfaces;
using Models.DTO.BackToFront.EntityCreationResult;
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

    public async Task<(AuthorCreationCode, Author?)> Create(AuthorCreationData data)
    {
        var owner = await _userAccessor.GetById(data.UserId);
        if (owner == null) return (AuthorCreationCode.InvalidUser, null);
        return (AuthorCreationCode.Successful, new Author(data.Name, owner));
    }
}