namespace Models.DTO.BackToFront.EntityCreationResult;

public enum RegistrationCode
{
    Successful,
    LoginTaken,
    EmailTaken,
    WeakPassword,
    UnknownError
}