using Database;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DatabaseServices.Services.Repositories.Implementations;

public interface IDbSupportChatHistoryRepository
{
    public IQueryable<SupportChatMessage> GetHistoryForUserId(string roomId);
    public Task AddMessageToUserHistory(SupportChatMessage message);
    public IQueryable<SupportChatMessage> GetAll();
}

public class DbSupportChatHistoryRepository : IDbSupportChatHistoryRepository
{
    private readonly AppDbContext _dbContext;

    public DbSupportChatHistoryRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<SupportChatMessage> GetHistoryForUserId(string roomId)
    {
        return _dbContext.SupportChatMessagesHistory.Where(m => m.RoomId == roomId)
            .Include(m => m.Sender);
    }

    public async Task AddMessageToUserHistory(SupportChatMessage message)
    {
        await _dbContext.SupportChatMessagesHistory.AddAsync(message);
        await _dbContext.SaveChangesAsync();
    }

    public IQueryable<SupportChatMessage> GetAll()
    {
        return _dbContext.SupportChatMessagesHistory;
    }
}