namespace Common
{
    public class LocalWeatherRepository : IWeatherRepository
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherForecast[] GetForecasts()
        {
            var forecasts = Enumerable.Range(1, 5).Select(index =>
               new WeatherForecast
               ( 
                   index,
                   DateTime.Now.AddDays(index),
                   Random.Shared.Next(-20, 55),
                   Summaries[Random.Shared.Next(Summaries.Length)]
               ))
               .ToArray();
            return forecasts;
        }
    }
}