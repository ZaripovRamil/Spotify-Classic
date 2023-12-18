using StaticAPI.ConfigurationExtensions;
using StaticAPI.ServiceCollectionExtensions;
using StaticAPI.WebApplicationExtensions;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentFiles();
builder.Configuration.AddEnvironmentVariables();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddApplicationServices(builder.Configuration);




var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    await app.EnsureTestDataUploadedAsync();
}

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();