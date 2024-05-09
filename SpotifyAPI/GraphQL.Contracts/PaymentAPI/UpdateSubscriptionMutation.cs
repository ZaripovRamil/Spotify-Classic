using Grpc.Core;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Http;

namespace GraphQL.Contracts.PaymentAPI;
[ExtendObjectType("Mutation")]
public class UpdateSubscriptionMutation
{
    private readonly IHttpContextAccessor _contextAccessor;
    
    private readonly PaymentService.PaymentServiceClient _paymentServiceClient =
        new(GrpcChannel.ForAddress("http://localhost:5170"));

    public UpdateSubscriptionMutation(IHttpContextAccessor contextAccessor)
    {
        _contextAccessor = contextAccessor;
    }

    public async Task<ResultDto?> UpdateSubscription(string id)
    {
        var authHeader = GetHttpAuthorizationHeader();
        var metadata = new Metadata { { "Authorization", authHeader ?? string.Empty } };
        return await _paymentServiceClient.UpdateSubscriptionAsync(new SubscriptionUpdateData
        {
            SubscriptionId = id
        }, headers: metadata);
    }

    private string? GetHttpAuthorizationHeader()
    {
        return _contextAccessor.HttpContext?.Request.Headers.Authorization;
    }
}