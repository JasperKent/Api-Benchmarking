using Common;
using Microsoft.AspNetCore.Mvc;

namespace ControllerApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherRepository _repository;

        public WeatherForecastController(IWeatherRepository repository)
        {
            _repository = repository;
        }

        public WeatherForecast[] Get()
        {
           return _repository.GetForecasts();
        }
    }
}