using Database.Services.Accessors.Interfaces;
using Database.Services.Factories.Interfaces;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Services.Factories.Implementations;

public class AlbumFactory : IAlbumFactory
{
    private readonly IDbAuthorAccessor _authorAccessor;
    private readonly IFileIdGenerator _idGenerator;

    public AlbumFactory(IDbAuthorAccessor authorAccessor, IFileIdGenerator idGenerator)
    {
        _authorAccessor = authorAccessor;
        _idGenerator = idGenerator;
    }

    public async Task<Album?> Create(AlbumCreationData aData)
    {
        var author = await _authorAccessor.GetById(aData.AuthorId);
        return author == null
            ? null
            : new Album(aData.Name, author, aData.AlbumType, aData.ReleaseDate, _idGenerator.GetId(aData));
    }
}