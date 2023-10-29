using ChatApi.Chat;
using ChatApi.ServiceCollectionExtensions;
using DatabaseServices.Services.Repositories.Implementations;
using Models.Configuration;
using Utils.LocalRun;
using Utils.ServiceCollectionExtensions;
using Utils.WebApplicationExtensions;

var builder = WebApplication.CreateBuilder(args);
EnvFileLoader.LoadFilesFromParentDirectory(".rabbitmq-secrets", ".postgres-secrets", "local.secrets", Path.Combine("..", "local.hostnames"), "local.kestrel-conf");

builder.Configuration.AddEnvironmentVariables();

builder.Services.AddDbContext(builder.Configuration);

var rabbitMqConfig = builder.Configuration.GetSection("RabbitMqConfig").Get<RabbitMqConfig>()!;
builder.Services.AddMasstransitRabbitMq(rabbitMqConfig, typeof(Program).Assembly);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.Configure<JwtTokenSettings>(builder.Configuration.GetSection("JWTTokenSettings"));
builder.Services.Configure<Hosts>(builder.Configuration.GetSection("Hosts"));

builder.Services.AddScoped<IDbSupportChatHistoryRepository, DbSupportChatHistoryRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddSignalR();

builder.Services.AddJwtAuthenticationWithSignalR(builder.Configuration);
builder.Services.AddSwaggerWithAuthorization();
builder.Services.AddAllCors();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.ApplyMigrations();
}
app.UseCors();

app.MapHub<ChatHub>("/chat");

app.UseAuthorization();

app.MapControllers();

app.Run();