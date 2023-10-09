using Database;
using DatabaseServices.Services.Accessors.Implementations;
using DatabaseServices.Services.Accessors.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Configuration;
using Utils.ServiceCollectionExtensions;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentVariables();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Spotify")).EnableThreadSafetyChecks());

builder.Services.AddScoped<IDbSupportChatHistoryAccessor, DbSupportChatHistoryAccessor>();

var rabbitMqConfig = builder.Configuration.GetSection("RabbitMqConfig").Get<RabbitMqConfig>()!;
builder.Services.AddMasstransitRabbitMq(rabbitMqConfig, typeof(Program).Assembly);

var app = builder.Build();

app.Run();