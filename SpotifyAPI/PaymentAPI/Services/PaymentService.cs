using DatabaseServices.Repositories;
using Grpc.Core;
using Microsoft.AspNetCore.Authorization;
using static Models.ValidationErrors.SubscriptionErrors;
using static Models.ValidationErrors.CommonConstants;

namespace PaymentAPI.Services;

[Authorize]
public class PaymentService : global::PaymentService.PaymentServiceBase
{
    private readonly ISubscriptionRepository _subscriptionRepository;

    public PaymentService(ISubscriptionRepository subscriptionRepository)
    {
        _subscriptionRepository = subscriptionRepository;
    }

    public override async Task<ResultDto> UpdateSubscription(SubscriptionUpdateData request, ServerCallContext context)
    {
        var subscription = await _subscriptionRepository.GetByIdAsync(request.SubscriptionId);
        if (subscription is null)
            return new ResultDto { Ok = false, Message = SubscriptionNotFound };
        var userId = GetContextUserId(context);
        try
        {
            await _subscriptionRepository.SetToUserAsync(userId, subscription);
        }
        catch (Exception e)
        {
            return new ResultDto { Ok = false, Message = e.Message };
        }
        return new ResultDto { Ok = true, Message = Successful };
    }

    private static string GetContextUserId(ServerCallContext context)
    {
        return context.GetHttpContext().User.Claims.FirstOrDefault(c => c.Type == "Id")?.Value ?? string.Empty;
    }
}