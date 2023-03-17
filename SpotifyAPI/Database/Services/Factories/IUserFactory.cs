using Models;
using Models.DTO;

namespace Database.Services.Factories;

public interface IUserFactory
{
    public User Create(RegistrationData rData);
}