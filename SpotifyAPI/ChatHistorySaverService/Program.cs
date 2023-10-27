using DatabaseServices.Services.Accessors.Implementations;
using DatabaseServices.Services.Accessors.Interfaces;
using Models.Configuration;
using Utils.LocalRun;
using Utils.ServiceCollectionExtensions;

var builder = WebApplication.CreateBuilder(args);

EnvFileLoader.LoadFilesFromParentDirectory(".rabbitmq-secrets", "local.secrets", Path.Combine("..", "local.hostnames"));

builder.Configuration.AddEnvironmentVariables();

builder.Services.AddDbContext(builder.Configuration);

builder.Services.AddScoped<IDbSupportChatHistoryAccessor, DbSupportChatHistoryAccessor>();

var rabbitMqConfig = builder.Configuration.GetSection("RabbitMqConfig").Get<RabbitMqConfig>()!;
builder.Services.AddMasstransitRabbitMq(rabbitMqConfig, typeof(Program).Assembly);

var app = builder.Build();

app.Run();