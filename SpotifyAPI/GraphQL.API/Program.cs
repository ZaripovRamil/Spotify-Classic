using GraphQL.API.ConfigurationExtensions;
using GraphQL.API.ServiceCollectionExtensions;
using GraphQL.Contracts.AuthAPI.Auth;
using GraphQL.Contracts.AuthAPI.Registration;
using GraphQL.Contracts.AuthAPI.User;
using GraphQL.Contracts.PaymentAPI;
using GraphQL.Contracts.PlayerAPI;
using GraphQL.Contracts.SearchAPI;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType(q => q.Name("Query"))
    .AddType<GetHistoryQuery>()
    .AddType<GetAlbumQuery>()
    .AddType<GetAlbumsQuery>()
    .AddType<SearchQuery>()
    .AddMutationType(m => m.Name("Mutation"))
    .AddType<RegistrationMutation>()
    .AddType<LoginMutation>()
    .AddType<UpdateSubscriptionMutation>()
    .AddInMemorySubscriptions();


builder.Configuration.AddEnvironmentFiles();
builder.Configuration.AddEnvironmentVariables();

builder.Services.AddApplicationServices(builder.Configuration);

var app = builder.Build();

app.UseCors();

app.UseAuthentication();

app.UseWebSockets();
app.MapGraphQL((PathString)"/graphql");
app.Run();