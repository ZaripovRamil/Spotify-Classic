using DatabaseServices.Services.EntityValidators.Interfaces;
using DatabaseServices.Services.Factories.Interfaces;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace DatabaseServices.Services.Factories.Implementations;

public class AlbumFactory : IAlbumFactory
{
    private readonly IFileIdGenerator _idGenerator;
    private readonly IAlbumValidator _albumValidator;

    public AlbumFactory(IFileIdGenerator idGenerator, IAlbumValidator albumValidator)
    {
        _idGenerator = idGenerator;
        _albumValidator = albumValidator;
    }

    public async Task<(AlbumValidationCode, Album?)> Create(AlbumCreationData data)
    {
        var validationResult = await _albumValidator.Validate(data);
        return ((AlbumValidationCode)validationResult.ValidationCode, validationResult.IsValid?
            new Album(data.Name, validationResult.Author, data.AlbumType, data.ReleaseYear, _idGenerator.GetId(data))
            :null);
    }
}