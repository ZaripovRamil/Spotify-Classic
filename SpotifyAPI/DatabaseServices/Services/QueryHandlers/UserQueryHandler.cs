using DatabaseServices.Services.Repositories.Implementations;
using Models.Entities;

namespace DatabaseServices.Services.QueryHandlers;

public interface IUserQueryHandler
{
    public Task<User?> GetById(string id);
    public Task<User?> GetByName(string name);
    public Task<User?> GetByEmail(string email);
    public List<User> GetAll();
}

public class UserQueryHandler : IUserQueryHandler
{
    private UserRepository _userRepository;

    public UserQueryHandler(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public Task<User?> GetById(string id)
    {
        return _userRepository.GetByIdAsync(id);
    }

    public Task<User?> GetByName(string name)
    {
        return _userRepository.GetByUsernameAsync(name);
    }

    public Task<User?> GetByEmail(string email)
    {
        return _userRepository.GetByEmailAsync(email);
    }

    public List<User> GetAll()
    {
        return _userRepository.GetAllUsers().ToList();
    }
}