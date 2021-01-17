using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherCompoment.Models;

namespace WeatherCompoment.Contracts
{
    public interface IWeatherService
    {
        CurrentWeather GetCurrentWeather(String location);
        //LocationForecast GetForecast(String location);
    }
}
