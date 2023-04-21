using Database.Services.Accessors.Interfaces;
using Database.Services.EntityValidators.Interfaces;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.DTO.InterServices.ValidationResult;

namespace Database.Services.EntityValidators.Implementations;

public class AlbumValidator:EntityValidator,IAlbumValidator
{
    private readonly IDbAuthorAccessor _authorAccessor;

    public AlbumValidator(IDbAuthorAccessor authorAccessor)
    {
        _authorAccessor = authorAccessor;
    }

    public async Task<AlbumValidationResult> Validate(AlbumCreationData data)
    {
        var state = (AlbumValidationCode) base.Validate(data).ValidationCode;
        var author = await _authorAccessor.GetById(data.AuthorId);
        if (data.ReleaseYear > DateTime.Now.Year||data.ReleaseYear<0)
            state = AlbumValidationCode.InvalidReleaseYear;
        if (author == null)
            state = AlbumValidationCode.InvalidAuthor;
        return new AlbumValidationResult(state, author);
    }
}