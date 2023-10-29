using Database;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DatabaseServices.Services.Repositories.Implementations;

public interface ISubscriptionRepository
{
    public Task<Subscription?> GetByIdAsync(string id);
    public IQueryable<Subscription> GetAll();
    public Task<Subscription?> GetByNameAsync(string name);
    Task SetToUserAsync(User user, Subscription subscription);
}

public class SubscriptionRepository : Repository, ISubscriptionRepository
{
    public SubscriptionRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<Subscription?> GetByIdAsync(string id)
    {
        return await GetAll().FirstOrDefaultAsync(s => s.Id == id);
    }

    public IQueryable<Subscription> GetAll()
    {
        return DbContext.Subscriptions;
    }

    public async Task<Subscription?> GetByNameAsync(string name)
    {
        return await GetAll().FirstOrDefaultAsync(s => s.Name == name);
    }

    public async Task SetToUserAsync(User user, Subscription subscription)
    {
        user.Subscription = subscription;
        if (ValidateSubscription(user))
            user.SubscriptionExpire += TimeSpan.FromDays(30);
        else user.SubscriptionExpire = (DateTime.Now + TimeSpan.FromDays(30)).ToUniversalTime();
        DbContext.Entry(user).State = EntityState.Modified;
        await DbContext.SaveChangesAsync();
    }

    private static bool ValidateSubscription(User user)
    {
        return user.Subscription != null && user.SubscriptionExpire > DateTime.Now;
    }
}