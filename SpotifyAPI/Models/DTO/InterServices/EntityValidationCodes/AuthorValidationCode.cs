namespace Models.DTO.InterServices.EntityValidationCodes;

public enum AuthorValidationCode
{
    Successful = EntityValidationCode.Successful,
    InvalidUser,
    EmptyName = EntityValidationCode.EmptyName,
    InvalidName = EntityValidationCode.InvalidName,
    UnknownError = EntityValidationCode.UnknownError
}