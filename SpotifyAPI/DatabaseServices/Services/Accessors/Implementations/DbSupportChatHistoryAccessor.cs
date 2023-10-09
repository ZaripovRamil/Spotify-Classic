using Database;
using DatabaseServices.Services.Accessors.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DatabaseServices.Services.Accessors.Implementations;

public class DbSupportChatHistoryAccessor : IDbSupportChatHistoryAccessor
{
    private readonly AppDbContext _dbContext;

    public DbSupportChatHistoryAccessor(AppDbContext dbContext)
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