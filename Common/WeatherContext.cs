using Microsoft.EntityFrameworkCore;

namespace Common
{
    public class WeatherContext : DbContext
    {
        public WeatherContext(DbContextOptions<WeatherContext> options)
            :base(options)
        {                
        }

        public DbSet<WeatherForecast> Forecasts { get; set; }
    }
}
