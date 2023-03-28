using Database.Services.Accessors.Interfaces;
using Database.Services.Factories.Interfaces;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Services.Factories.Implementations;

public class AlbumFactory:IAlbumFactory
{
    private readonly IDbAuthorAccessor _authorAccessor;

    public AlbumFactory(IDbAuthorAccessor authorAccessor)
    {
        _authorAccessor = authorAccessor;
    }

    public async Task<Album?> Create(AlbumCreationData aData)
    {
        var author = await _authorAccessor.GetById(aData.AuthorId);
        return author == null ? null : new Album(aData.Name, author, aData.AlbumType, aData.ReleaseDate);
    }
}