using DatabaseServices.Repositories;
using Utils.CQRS;

namespace AuthAPI.Features.UpdateSubscription;

public class CommandHandler : ICommandHandler<Command>
{
    private readonly ISubscriptionRepository _subscriptionRepository;

    public CommandHandler(ISubscriptionRepository subscriptionRepository)
    {
        _subscriptionRepository = subscriptionRepository;
    }

    public async Task<Result> Handle(Command request, CancellationToken cancellationToken)
    {
        var res = new Result();
        var subscription = await _subscriptionRepository.GetByIdAsync(request.Data.SubscriptionId);
        if (subscription == null)
        {
            res.Fail();
            res.AddErrors("No such subscription");
        }

        await _subscriptionRepository.SetToUserAsync(request.User!, subscription);
        return res;
    }
}