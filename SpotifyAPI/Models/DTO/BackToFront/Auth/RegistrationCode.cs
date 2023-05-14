namespace Models.DTO.BackToFront.Auth;

public enum RegistrationCode
{
    Successful,
    LoginTaken,
    EmailTaken,
    WeakPassword,
    UnknownError,
    InvalidUsername
}