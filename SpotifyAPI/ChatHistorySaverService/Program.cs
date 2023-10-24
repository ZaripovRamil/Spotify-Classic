using DatabaseServices.Services.Accessors.Implementations;
using DatabaseServices.Services.Accessors.Interfaces;
using Models.Configuration;
using Utils;
using Utils.ServiceCollectionExtensions;

var builder = WebApplication.CreateBuilder(args);

LocalEnvFileLoader.LoadFilesFromParentDirectory(".rabbitmq-secrets", "local.secrets", "local.hostnames");

builder.Configuration.AddEnvironmentVariables();

builder.Services.AddDbContext(builder.Configuration);

builder.Services.AddScoped<IDbSupportChatHistoryAccessor, DbSupportChatHistoryAccessor>();

var rabbitMqConfig = builder.Configuration.GetSection("RabbitMqConfig").Get<RabbitMqConfig>()!;
builder.Services.AddMasstransitRabbitMq(rabbitMqConfig, typeof(Program).Assembly);

var app = builder.Build();

app.Run();