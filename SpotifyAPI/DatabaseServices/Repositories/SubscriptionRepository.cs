using Database;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using static Models.ValidationErrors.SubscriptionErrors;

namespace DatabaseServices.Repositories;

public interface ISubscriptionRepository : IUniqueNameEntityRepository<Subscription>
{
    Task SetToUserAsync(string userId, Subscription? subscription);
}

public class SubscriptionRepository : Repository, ISubscriptionRepository
{
    public SubscriptionRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task AddAsync(Subscription subscription)
    {
        await DbContext.Subscriptions.AddAsync(subscription);
        await DbContext.SaveChangesAsync();
    }

    public async Task<Subscription?> GetByIdAsync(string id)
    {
        return await GetAll().FirstOrDefaultAsync(s => s.Id == id);
    }

    public IQueryable<Subscription> GetAll()
    {
        return DbContext.Subscriptions;
    }

    public async Task DeleteAsync(Subscription subscription)
    {
        DbContext.Subscriptions.Remove(subscription);
        await DbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Subscription subscription)
    {
        var toChange = (await GetByIdAsync(subscription.Id))!;
        toChange.Name = subscription.Name;
        await DbContext.SaveChangesAsync();
    }

    public async Task<Subscription?> GetByNameAsync(string name)
    {
        return await GetAll().FirstOrDefaultAsync(s => s.Name == name);
    }

    public async Task SetToUserAsync(string userId, Subscription? subscription)
    {
        var user = await DbContext.Users.FirstOrDefaultAsync(u => u.Id == userId);
        if (user is null) throw new Exception(UserNotFound);
        user.Subscription = subscription;
        user.SubscriptionExpire = ValidateSubscription(user)
            ? user.SubscriptionExpire?.Add(TimeSpan.FromDays(30))
            : (DateTime.Now + TimeSpan.FromDays(30)).ToUniversalTime();
        await DbContext.SaveChangesAsync();
    }

    private static bool ValidateSubscription(User user)
    {
        return user.Subscription != null && user.SubscriptionExpire > DateTime.Now;
    }
}