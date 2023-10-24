using ChatApi.Chat;
using ChatApi.ServiceCollectionExtensions;
using ChatApi.Startup;
using DatabaseServices.Services.Accessors.Implementations;
using DatabaseServices.Services.Accessors.Interfaces;
using Models.Configuration;
using Utils.ServiceCollectionExtensions;

var builder = WebApplication.CreateBuilder(args);

LocalEnvFiles.Load(Directory.GetParent(Directory.GetCurrentDirectory())!.FullName);

builder.Configuration.AddEnvironmentVariables();

builder.Services.AddDbContext(builder.Configuration);


var rabbitMqConfig = builder.Configuration.GetSection("RabbitMqConfig").Get<RabbitMqConfig>()!;
builder.Services.AddMasstransitRabbitMq(rabbitMqConfig, typeof(Program).Assembly);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.Configure<JwtTokenSettings>(builder.Configuration.GetSection("JWTTokenSettings"));
builder.Services.Configure<Hosts>(builder.Configuration.GetSection("Hosts"));

builder.Services.AddScoped<IDbSupportChatHistoryAccessor, DbSupportChatHistoryAccessor>();
builder.Services.AddScoped<IDbUserAccessor, DbUserAccessor>();

builder.Services.AddSignalR();

builder.Services.AddJwtAuthenticationWithSignalR(builder.Configuration);
builder.Services.AddSwaggerWithAuthorization();
builder.Services.AddAllCors();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();

app.MapHub<ChatHub>("/chat");

app.UseAuthorization();

app.MapControllers();

app.Run();