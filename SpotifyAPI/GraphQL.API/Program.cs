using GraphQL.Contracts.AuthAPI.Auth;
using GraphQL.Contracts.AuthAPI.Registration;
using GraphQL.Contracts.AuthAPI.User;
using GraphQL.Contracts.PlayerAPI;
using GraphQL.Contracts.SearchAPI;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddGraphQLServer()
    .AddMutationType<LoginMutation>()
    .AddMutationType<RegistrationMutation>()
    .AddQueryType<GetHistoryQuery>()
    .AddQueryType<GetAlbumQuery>()
    .AddQueryType<GetAlbumsQuery>()
    .AddQueryType<SearchQuery>()
    .AddInMemorySubscriptions();

var app = builder.Build();
app.UseWebSockets();
app.MapGraphQL((PathString)"/graphql");
app.Run();