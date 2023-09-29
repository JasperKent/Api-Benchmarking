namespace Common
{
    public interface IWeatherRepository
    {
        WeatherForecast[] GetForecasts();
    }
}