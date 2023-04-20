namespace Models.DTO.InterServices.EntityValidationCodes;

public enum AlbumValidationCode
{
    Successful = EntityValidationCode.Successful,
    EmptyName = EntityValidationCode.EmptyName,
    InvalidName = EntityValidationCode.InvalidName,
    UnknownError = EntityValidationCode.UnknownError,
    InvalidAuthor,
    InvalidReleaseYear
}