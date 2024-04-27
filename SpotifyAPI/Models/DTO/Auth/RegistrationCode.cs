namespace Models.DTO.Auth;

public enum RegistrationCode
{
    Successful,
    LoginTaken,
    EmailTaken,
    WeakPassword,
    UnknownError,
    InvalidUsername
}