using Models.DTO;

namespace Models;

public interface IUserFactory
{
    public User Create(RegistrationData rData);
}