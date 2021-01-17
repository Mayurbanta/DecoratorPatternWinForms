using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherCompoment.Contracts;
using WeatherCompoment.Models;

namespace WeatherCompoment.Service
{
    public class WeatherService : IWeatherService
    {
        public CurrentWeather GetCurrentWeather(string location)
        {

            //Imagine this is a service
            CurrentWeather weather = new CurrentWeather
            {
                Location = location,
                Temperature = 24,
                WeatherCondition = WeatherCondition.Cloudy
            };
            return weather;
        }
    }
}
