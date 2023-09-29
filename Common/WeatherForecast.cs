namespace Common
{
    public record WeatherForecast(int Id, DateTime Date, int TemperatureC, string? Summary)
    {
        public WeatherForecast():this (0, DateTime.MinValue, 0, null)
        {
        }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
