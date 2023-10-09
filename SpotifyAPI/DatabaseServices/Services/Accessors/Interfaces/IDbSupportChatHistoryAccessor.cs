using Models.Entities;

namespace DatabaseServices.Services.Accessors.Interfaces;

public interface IDbSupportChatHistoryAccessor
{
    public IQueryable<SupportChatMessage> GetHistoryForUserId(string roomId);
    public Task AddMessageToUserHistory(SupportChatMessage message);
    public IQueryable<SupportChatMessage> GetAll();
}