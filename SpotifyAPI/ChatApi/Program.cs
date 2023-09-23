using System.Text;
using ChatApi.Chat;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Configuration.AddEnvironmentVariables();
builder.Services.Configure<JwtTokenSettings>(builder.Configuration.GetSection("JWTTokenSettings"));
builder.Services.Configure<Hosts>(builder.Configuration.GetSection("Hosts"));

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
                if (string.IsNullOrEmpty(accessToken) == false)
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
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();