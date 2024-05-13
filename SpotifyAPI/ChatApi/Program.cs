using ChatApi.Chat;
using ChatApi.ConfigurationExtensions;
using ChatApi.Features.MobileChat;
using ChatApi.ServiceCollectionExtensions;
using Utils.ServiceCollectionExtensions;
using Utils.WebApplicationExtensions;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentFiles();
builder.Configuration.AddEnvironmentVariables();

builder.Services.AddMasstransitRabbitMq(builder.Configuration, typeof(Program).Assembly);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddGrpc();

builder.Services.AddApplicationServices(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.ApplyMigrations();
}
app.UseCors();

app.MapHub<ChatHub>("/chat");

app.UseAuthentication();
app.UseAuthorization();

app.MapGrpcService<ChatGrpcService>();

app.MapControllers();

app.Run();