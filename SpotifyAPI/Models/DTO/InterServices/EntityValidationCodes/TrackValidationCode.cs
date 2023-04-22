namespace Models.DTO.InterServices.EntityValidationCodes;

public enum TrackValidationCode
{
    Successful = EntityValidationCode.Successful,
    EmptyName = EntityValidationCode.EmptyName,
    InvalidName = EntityValidationCode.InvalidName,
    UnknownError = EntityValidationCode.UnknownError,
    InvalidAlbum,
    InvalidGenres
}