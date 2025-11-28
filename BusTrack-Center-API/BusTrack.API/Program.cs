using BusTrack_center_API.Searchroutes.Application.Internal.CommandServices;
using BusTrack_center_API.Searchroutes.Application.Internal.QueryServices;
using BusTrack_center_API.Searchroutes.Domain.Repositories;
using BusTrack_center_API.Searchroutes.Domain.Services;
using BusTrack_center_API.Searchroutes.Infrastructure.Persistence.EFC.Repositories;
using BusTrack_center_API.Shared.Domain.Repositories;
using BusTrack_center_API.Shared.Infrastructure.Interfaces.ASP.Configuration;
using BusTrack_center_API.Shared.Infrastructure.Persistence.EFC.Configuration;
using BusTrack_center_API.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Configure Lower Case URLs
builder.Services.AddRouting(options => options.LowercaseUrls = true);

// Configure Kebab Case Route Naming Convention
builder.Services.AddControllers(options => options.Conventions.Add(new KebabCaseRouteNamingConvention()));

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => options.EnableAnnotations());

// Add Database Connection

// Configuration Database Context and Logging Levels
if (builder.Environment.IsDevelopment())
    builder.Services.AddDbContext<AppDbContext>(options =>
    {
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        if (connectionString is null)
            throw new Exception("Connection string is null");
        options.UseMySQL(connectionString)
            .LogTo(Console.WriteLine, LogLevel.Information)
            .EnableSensitiveDataLogging()
            .EnableDetailedErrors();
    });
else if (builder.Environment.IsProduction())
    builder.Services.AddDbContext<AppDbContext>(options =>
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();
        var connectionStringTemplate = configuration.GetConnectionString("DefaultConnection");
        if (connectionStringTemplate is null)
            throw new Exception("Connection string is null");
        var connectionString = Environment.ExpandEnvironmentVariables(connectionStringTemplate);
        if (connectionString is null)
            throw new Exception("Connection string is null after expanding environment variables");
        options.UseMySQL(connectionString)
            .LogTo(Console.WriteLine, LogLevel.Error)
            .EnableDetailedErrors();
    });

// Configure Dependency Injection for Application Services

// Shared Bounded Context Injections 
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// News Bounded Context Injections
builder.Services.AddScoped<IRutaRepository, RutaRepository>();
builder.Services.AddScoped<IRutaQueryService, RutaQueryService>();
builder.Services.AddScoped<IRutaCommandService, RutaCommandService>();
    
var app = builder.Build();

//Verify Database Objects are created
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var dbContext = services.GetRequiredService<AppDbContext>();
    dbContext.Database.EnsureCreated();
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();