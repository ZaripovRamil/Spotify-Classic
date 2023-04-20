using Database.Services.EntityValidators.Interfaces;
using Database.Services.Factories.Interfaces;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace Database.Services.Factories.Implementations;

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