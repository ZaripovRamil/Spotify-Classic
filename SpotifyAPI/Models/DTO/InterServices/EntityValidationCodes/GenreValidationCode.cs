namespace Models.DTO.InterServices.EntityValidationCodes;

public enum GenreValidationCode
{
    Successful = EntityValidationCode.Successful,
    EmptyName = EntityValidationCode.EmptyName,
    InvalidName = EntityValidationCode.InvalidName,
    UnknownError = EntityValidationCode.UnknownError,
    AlreadyExists
}