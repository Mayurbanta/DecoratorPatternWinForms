using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherCompoment.Models;

namespace WeatherCompoment.Contracts
{
    public class WeatherServiceCachingDecorator : IWeatherService
    {

        private readonly IWeatherService _innerWeatherService;
        private readonly ICache _cache;
        public WeatherServiceCachingDecorator(IWeatherService innerWeatherService, ICache cache)
        {
            _innerWeatherService = innerWeatherService;
            _cache = cache;
        }

        public CurrentWeather GetCurrentWeather(string location)
        {
            string cacheKey = $"WeatherCondition::{location}";

            object weatherCache = _cache.GetDataFromCache(cacheKey);
            if (weatherCache != null)
            {
                return (CurrentWeather)weatherCache;
            }
            else
            {
                var currentConditions = _innerWeatherService.GetCurrentWeather(location);
                _cache.AddToCache(cacheKey, currentConditions);
                return currentConditions;
            }
        }
    }
}
