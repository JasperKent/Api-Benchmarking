using Common;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<IWeatherRepository, SqlWeatherRepository>();
builder.Services.AddDbContext<WeatherContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

//PopulateDatabase();

app.MapControllers();

app.Run();

//void PopulateDatabase()
//{
//    using var scope = app.Services.CreateScope();
//    using var db = scope.ServiceProvider.GetRequiredService<WeatherContext>();

//    var repos = new LocalWeatherRepository();

//    var forecasts = repos.GetForecasts();

//    db.Forecasts.AddRange(forecasts.Select (f => f with { Id = 0 }));

//    db.SaveChanges();
//}