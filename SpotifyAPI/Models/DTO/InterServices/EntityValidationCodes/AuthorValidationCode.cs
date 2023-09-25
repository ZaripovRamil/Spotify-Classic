namespace Models.DTO.InterServices.EntityValidationCodes;

public enum AuthorValidationCode
{
    Successful = EntityValidationCode.Successful,
    EmptyName = EntityValidationCode.EmptyName,
    InvalidName = EntityValidationCode.InvalidName,
    UnknownError = EntityValidationCode.UnknownError,
    InvalidUser
}