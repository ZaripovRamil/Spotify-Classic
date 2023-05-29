using Models.Entities;

namespace Models.DTO.BackToFront.Light;

public class SubscriptionLight
{
    public SubscriptionLight(Subscription subscription)
    {
        Id = subscription.Id;
        Name = subscription.Name;
        Price = subscription.Price;
    }

    public string Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}