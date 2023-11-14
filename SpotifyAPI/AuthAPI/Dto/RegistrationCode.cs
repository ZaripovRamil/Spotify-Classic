namespace AuthAPI.Dto;

public enum RegistrationCode
{
    Successful,
    LoginTaken,
    EmailTaken,
    WeakPassword,
    UnknownError,
    InvalidUsername
}