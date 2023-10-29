using DatabaseServices.Services.Repositories.Implementations;
using Models.Entities;

namespace DatabaseServices.Services.QueryHandlers;

public interface IHistoryQueryHandler
{
    public Task<List<Track>> GetUserHistory(string userId);
}

public class HistoryQueryHandler : IHistoryQueryHandler
{
    private readonly IUserRepository _userRepository;

    public HistoryQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<List<Track>> GetUserHistory(string userId)
    {
        return (await _userRepository.GetByIdAsync(userId))?.History ?? new List<Track>();
    }
}