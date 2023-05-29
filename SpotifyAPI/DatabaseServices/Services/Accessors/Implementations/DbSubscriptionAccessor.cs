using Database;
using DatabaseServices.Services.Accessors.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DatabaseServices.Services.Accessors.Implementations;

public class DbSubscriptionAccessor : DbAccessor, IDbSubscriptionAccessor
{
    public DbSubscriptionAccessor(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<Subscription?> GetById(string id)
    {
        return await GetAll().FirstOrDefaultAsync(s => s.Id == id);
    }

    public IQueryable<Subscription> GetAll()
    {
        return DbContext.Subscriptions;
    }

    public async Task<Subscription?> GetByName(string name)
    {
        return await GetAll().FirstOrDefaultAsync(s => s.Name == name);
    }

    public async Task SetToUser(User user, Subscription subscription)
    {
        user!.Subscription = subscription;
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