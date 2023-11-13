using Models.DTO.FrontToBack;
using Models.Entities;
using Utils.CQRS;

namespace AuthAPI.Features.UpdateSubscription;

public record Command(SubscriptionUpdateData Data, User? User) : ICommand;