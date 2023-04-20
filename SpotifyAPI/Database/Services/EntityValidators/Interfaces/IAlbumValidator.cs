using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.ValidationResult;

namespace Database.Services.EntityValidators.Interfaces;

public interface IAlbumValidator
{
    public Task<AlbumValidationResult> Validate(AlbumCreationData data);
}