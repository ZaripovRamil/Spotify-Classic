using PaymentAPI.ConfigurationExtensions;
using PaymentAPI.ServiceCollectionExtensions;
using Utils.WebApplicationExtensions;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentFiles();
builder.Configuration.AddEnvironmentVariables();

builder.Services.AddGrpc();

builder.Services.AddApplicationServices(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.ApplyMigrations();
}

app.Use(async (context, next) =>
{
    Console.WriteLine($"Request {DateTime.Now}: {context.Request.Path}");
    await next();
    Console.WriteLine($"Response {DateTime.Now}: {context.Response.StatusCode}");
});

app.UseCors();


app.UseAuthentication();

app.UseAuthorization();

app.MapGrpcService<PaymentAPI.Services.PaymentService>();

app.Run();