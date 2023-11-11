using Database;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DatabaseServices.Repositories;

public interface ISupportChatHistoryRepository : IRepository<SupportChatMessage>
{
    public IQueryable<SupportChatMessage> GetHistoryForUserId(string roomId);
}

public class SupportChatHistoryRepository : Repository, ISupportChatHistoryRepository
{
    public SupportChatHistoryRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public IQueryable<SupportChatMessage> GetHistoryForUserId(string roomId)
    {
        return DbContext.SupportChatMessagesHistory.Where(m => m.RoomId == roomId)
            .Include(m => m.Sender);
    }

    public async Task AddAsync(SupportChatMessage item)
    {
        await DbContext.SupportChatMessagesHistory.AddAsync(item);
        await DbContext.SaveChangesAsync();
    }

    public async Task<SupportChatMessage?> GetByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public IQueryable<SupportChatMessage> GetAll()
    {
        return DbContext.SupportChatMessagesHistory;
    }

    public async Task DeleteAsync(SupportChatMessage item)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(SupportChatMessage item)
    {
        throw new NotImplementedException();
    }
}