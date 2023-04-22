using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.ValidationResult;

namespace DatabaseServices.Services.EntityValidators.Interfaces;

public interface IAlbumValidator
{
    public Task<AlbumValidationResult> Validate(AlbumCreationData data);
}