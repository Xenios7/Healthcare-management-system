using System.Text;
using EHRNurse.Api.Services;
using EHRNurse.Api.Interfaces; 
using EHRNurse.Data.Interfaces;
using EHRNurse.Data.Models;
using EHRNurse.Data.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Npgsql; 

var builder = WebApplication.CreateBuilder(args);

// 1. Add DbContext (PostgreSQL)
builder.Services.AddDbContext<AppDbContext>(options =>
    options
        .UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
        .UseSnakeCaseNamingConvention()
);

// 2. JWT options
builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection("Jwt"));
var jwt = builder.Configuration.GetSection("Jwt").Get<JwtOptions>()!;

// 3. Dependency Injection (Register your Services here!)
builder.Services.AddScoped<IUserRepository, UserRepository>();

// Service registrations
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IInpatientService, InpatientService>();
builder.Services.AddScoped<IBarcodeService, BarcodeService>();
builder.Services.AddScoped<IShiftService, ShiftService>(); 

// Log connection string (without password)
var conn = builder.Configuration.GetConnectionString("DefaultConnection");
Console.WriteLine($"Using connection: {new NpgsqlConnectionStringBuilder(conn) { Password = "" }}");

// 4. Authentication
builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(opt =>
    {
        opt.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwt.Issuer,
            ValidAudience = jwt.Audience,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Key))
        };
    });

builder.Services.AddAuthorization();

// 5. CORS (Allow everyone for now)
builder.Services.AddCors(policy =>
{
    policy.AddDefaultPolicy(p => p
        .AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod());
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Enable legacy timestamp behavior for PostgreSQL
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

var app = builder.Build();

// 6. Pipeline
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseCors();

app.UseAuthentication();
app.UseAuthorization();


app.Urls.Add("http://0.0.0.0:5164");

app.MapControllers();

app.Run();