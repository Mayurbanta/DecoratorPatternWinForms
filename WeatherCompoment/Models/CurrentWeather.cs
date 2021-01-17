using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherCompoment.Models
{
    public enum WeatherCondition
    {
        Sunny,
        Rain,
        Cloudy
    }

    public class CurrentWeather
    {
        public string Location { get; set; }
        public double Temperature { get; set; }
        public WeatherCondition WeatherCondition { get; set; }
    }
}
