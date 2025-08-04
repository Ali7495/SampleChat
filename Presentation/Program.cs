using Messaging.Application.Common.JWT;
using Messaging.Application.Common.JWT.Interfaces;
using Messaging.Application.Common.Middlewares;
using Messaging.Infrastracture.Common.JWT;
using Messaging.Infrastracture.Data;
using Messaging.IoC;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

#region JWT

builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));
builder.Services.AddScoped<IJwtTokenGenerator,JwtTokenGenerator>();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    var settings = builder.Configuration.GetSection("JwtSettings").Get<JwtSettings>();
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = settings.Issuer,
        ValidAudience = settings.Audience,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(settings.Secret))
    };
});

#endregion

builder.Services.AddDbContext<UserManagementDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpContextAccessor();

DependencyContainer.RegisterServices(builder.Services);

var app = builder.Build();

app.UseMiddleware<ExceptionHandlerMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
