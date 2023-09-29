using Common;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IWeatherRepository, SqlWeatherRepository>();
builder.Services.AddDbContext<WeatherContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.MapGet("/weatherforecast", (IWeatherRepository repository) => repository.GetForecasts());

app.Run();


