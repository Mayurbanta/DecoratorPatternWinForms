using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherCompoment.Contracts
{
    public interface ICache
    {
        void AddToCache(string cacheKey, object cacheObject);
        object GetDataFromCache(string cacheKey);
    }
}
