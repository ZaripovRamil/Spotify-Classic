using System.Text;
using ChatApi.Chat;
using Database;
using DatabaseServices.Services.Accessors.Implementations;
using DatabaseServices.Services.Accessors.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Models;
using Utils;

var builder = WebApplication.CreateBuilder(args);

// EnvFileLoader.Load("local.hostnames");
var parent = Directory.GetParent(Directory.GetCurrentDirectory())!.FullName;
var files = EnvFileLoader.CombinePaths(parent, ".secrets", "local.hostnames", ".kestrel-conf");
foreach (var file in files)
{
    EnvFileLoader.Load(file);
}

builder.Configuration.AddEnvironmentVariables();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Spotify")).EnableThreadSafetyChecks());

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.Configure<JwtTokenSettings>(builder.Configuration.GetSection("JWTTokenSettings"));
builder.Services.Configure<Hosts>(builder.Configuration.GetSection("Hosts"));

builder.Services.AddScoped<IDbSupportChatHistoryAccessor, DbSupportChatHistoryAccessor>();
builder.Services.AddScoped<IDbUserAccessor, DbUserAccessor>();

builder.Services.AddAuthentication( options => {
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(opts =>
    {
        opts.RequireHttpsMetadata = false;
        opts.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["JWTTokenSettings:Issuer"],
            ValidAudience = builder.Configuration["JWTTokenSettings:Audience"],
            IssuerSigningKey =
                new SymmetricSecurityKey(
                    Encoding.ASCII.GetBytes(builder.Configuration.GetValue<string>("JWTTokenSettings:Key")!))
        };
        opts.Events = new JwtBearerEvents
        {
            OnMessageReceived = context =>
            {
                var accessToken = context.Request.Query["access_token"];
                if (!string.IsNullOrEmpty(accessToken))
                {
                    context.Token = accessToken;
                }

                return Task.CompletedTask;
            }
        };
        
    });
builder.Services.AddSignalR();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(corsPolicyBuilder =>
    {
        corsPolicyBuilder
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
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