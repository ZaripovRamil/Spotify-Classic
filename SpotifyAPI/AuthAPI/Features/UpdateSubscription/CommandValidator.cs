using DatabaseServices.Repositories;
using FluentValidation;
using Models.DTO.FrontToBack;
using static Models.Entities.ValidationErrors.SubscriptionErrors;

namespace AuthAPI.Features.UpdateSubscription;

public class CommandValidator : AbstractValidator<Command>
{
    private readonly ISubscriptionRepository _subscriptionRepository;

    public CommandValidator(ISubscriptionRepository subscriptionRepository)
    {
        _subscriptionRepository = subscriptionRepository;
        
        RegisterRules();
    }

    private void RegisterRules()
    {
        RuleFor(c => c.Data)
            .MustAsync(Exist)
            .WithMessage(SubscriptionNotFound);
    }

    private async Task<bool> Exist(SubscriptionUpdateData data, CancellationToken cancellationToken) =>
        await _subscriptionRepository.GetByIdAsync(data.SubscriptionId) is not null;
}