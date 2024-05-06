using GraphQL.Contracts.AuthAPI.Auth;
using GraphQL.Contracts.AuthAPI.Registration;
using GraphQL.Contracts.AuthAPI.User;
using GraphQL.Contracts.PaymentAPI;
using GraphQL.Contracts.PlayerAPI;
using GraphQL.Contracts.SearchAPI;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddGraphQLServer()
    .AddMutationType(m => m.Name("Mutation"))
    .AddType<RegistrationMutation>()
    .AddType<LoginMutation>()
    .AddType<UpdateSubscriptionMutation>()
    .AddQueryType(q => q.Name("Query"))
    .AddType<GetHistoryQuery>()
    .AddType<GetAlbumQuery>()
    .AddType<GetAlbumsQuery>()
    .AddType<SearchQuery>()
    .AddInMemorySubscriptions();

var app = builder.Build();
app.UseWebSockets();
app.MapGraphQL((PathString)"/graphql");
app.Run();