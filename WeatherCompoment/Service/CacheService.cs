using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherCompoment.Contracts;
using System.Runtime.Caching;

namespace WeatherCompoment.Service
{
    public class CacheService : ICache
    {
         ObjectCache cache = MemoryCache.Default;
        public void AddToCache(string cacheKey, object cacheObject)
        {
            CacheItemPolicy cacheItemPolicy = new CacheItemPolicy
            {
                AbsoluteExpiration = DateTime.Now.AddHours(1.0)
            };
            cache.Add(cacheKey, cacheObject, cacheItemPolicy);
        }

        public object GetDataFromCache(string cacheKey)
        {
            object obj = null;
            if (cache.Contains(cacheKey))
                obj =  cache.Get(cacheKey);
            return obj;
        }
    }
}
