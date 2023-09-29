using System;
namespace Common
{
    public class SqlWeatherRepository : IWeatherRepository
    {
        private readonly WeatherContext _context;

        public SqlWeatherRepository(WeatherContext context)
        {
            _context = context;
        }

        public WeatherForecast[] GetForecasts() => _context.Forecasts.ToArray();
    }
}
