using GraphQL.Contracts.AuthAPI.Auth;
using Grpc.Net.Client;

namespace GraphQL.Contracts.PaymentAPI;
[ExtendObjectType("Mutation")]
public class UpdateSubscriptionMutation
{
    private readonly PaymentService.PaymentServiceClient _paymentServiceClient =
        new(GrpcChannel.ForAddress("http://localhost:5170"));

    public async Task<ResultDto?> UpdateSubscription(string id)
    {
        return await _paymentServiceClient.UpdateSubscriptionAsync(new SubscriptionUpdateData
        {
            SubscriptionId = id
        });
    }
}