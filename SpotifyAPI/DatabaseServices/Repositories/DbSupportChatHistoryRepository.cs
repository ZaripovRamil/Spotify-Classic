using Database;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DatabaseServices.Repositories;

public interface IDbSupportChatHistoryRepository
{
    public IQueryable<SupportChatMessage> GetHistoryForUserId(string roomId);
    public Task AddMessageToUserHistoryAsync(SupportChatMessage message);
    public IQueryable<SupportChatMessage> GetAll();
}

public class DbSupportChatHistoryRepository : Repository, IDbSupportChatHistoryRepository
{
    public DbSupportChatHistoryRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public IQueryable<SupportChatMessage> GetHistoryForUserId(string roomId)
    {
        return DbContext.SupportChatMessagesHistory.Where(m => m.RoomId == roomId)
            .Include(m => m.Sender);
    }

    public async Task AddMessageToUserHistoryAsync(SupportChatMessage message)
    {
        await DbContext.SupportChatMessagesHistory.AddAsync(message);
        await DbContext.SaveChangesAsync();
    }

    public IQueryable<SupportChatMessage> GetAll()
    {
        return DbContext.SupportChatMessagesHistory;
    }
}