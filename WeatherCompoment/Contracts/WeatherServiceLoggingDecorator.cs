using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherCompoment.Models;

namespace WeatherCompoment.Contracts
{
    public class WeatherServiceLoggingDecorator : IWeatherService
    {
        private IWeatherService _innerWeatherService;
        private Ilogger _logger;

        public WeatherServiceLoggingDecorator(IWeatherService weatherService, Ilogger logger)
        {
            _innerWeatherService = weatherService;
            _logger = logger;
        }
        public CurrentWeather GetCurrentWeather(string location)
        {

            CurrentWeather weather = _innerWeatherService.GetCurrentWeather(location);
            _logger.LogToFile("Temperature in " + location + " at " + DateTime.Now + " is " + weather.Temperature);
            return weather;
        }
    }
}
