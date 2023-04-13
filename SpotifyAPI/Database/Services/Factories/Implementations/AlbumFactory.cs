using Database.Services.Accessors.Interfaces;
using Database.Services.Factories.Interfaces;
using Models.DTO.BackToFront.EntityCreationResult;
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

    public async Task<(AlbumCreationCode, Album?)> Create(AlbumCreationData data)
    {
        var author = await _authorAccessor.GetById(data.AuthorId);
        if (author == null) return (AlbumCreationCode.InvalidAuthor, null);
        return (AlbumCreationCode.Successful,
            new Album(data.Name, author, data.AlbumType, data.ReleaseDate, _idGenerator.GetId(data)));
    }
}