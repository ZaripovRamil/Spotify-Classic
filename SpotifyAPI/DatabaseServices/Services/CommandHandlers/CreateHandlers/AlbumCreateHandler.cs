using DatabaseServices.Services.EntityValidators.Interfaces;
using DatabaseServices.Services.Repositories.Implementations;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace DatabaseServices.Services.CommandHandlers.CreateHandlers;

public interface IAlbumCreateHandler
{
    public Task<AlbumCreationResult> CreateAsync(AlbumCreationData data);
}

public class AlbumCreateHandler : IAlbumCreateHandler
{
    private readonly IAlbumRepository _albumRepository;
    private readonly IFileIdGenerator _idGenerator;
    private readonly IAlbumValidator _albumValidator;

    public AlbumCreateHandler(IFileIdGenerator idGenerator, IAlbumValidator albumValidator,
        IAlbumRepository albumRepository)
    {
        _idGenerator = idGenerator;
        _albumValidator = albumValidator;
        _albumRepository = albumRepository;
    }

    public async Task<AlbumCreationResult> CreateAsync(AlbumCreationData data)
    {
        var validationResult = await _albumValidator.Validate(data);
        var album = validationResult.IsValid
            ? new Album(data.Name, validationResult.Author!, data.AlbumType, data.ReleaseYear, _idGenerator.GetId(data))
            : null;
        if (album != null)
            await _albumRepository.AddAsync(album);
        return new AlbumCreationResult((AlbumValidationCode)validationResult.ValidationCode, album);
    }
}