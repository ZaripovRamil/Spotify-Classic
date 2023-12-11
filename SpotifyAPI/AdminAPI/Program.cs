using AdminAPI.ConfigurationExtensions;
using AdminAPI.Features.Albums.Create;
using AdminAPI.Features.Albums.Create.Metadata;
using AdminAPI.ServiceCollectionExtensions;
using AdminAPI.Services;
using Models.Metadata;
using Utils.WebApplicationExtensions;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentFiles();
builder.Configuration.AddEnvironmentVariables();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddApplicationServices(builder.Configuration);

builder.Services.AddScoped<IMetadataCreator<Command, ImageMetadata>, PreviewMetadataCreator>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.ApplyMigrations();
}

app.UseCors();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();