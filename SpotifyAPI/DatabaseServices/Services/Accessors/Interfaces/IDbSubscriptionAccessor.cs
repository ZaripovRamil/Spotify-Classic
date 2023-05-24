using Models.Entities;

namespace DatabaseServices.Services.Accessors.Interfaces;

public interface IDbSubscriptionAccessor
{
    public Task<Subscription?> GetById(string id);
    public IQueryable<Subscription> GetAll();
    public Task<Subscription?> GetByName(string name);
    Task SetToUser(User user, Subscription subscription);
}