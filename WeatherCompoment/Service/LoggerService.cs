using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherCompoment.Contracts;

namespace WeatherCompoment.Service
{
    public class LoggerService : Ilogger
    {
        public void LogToFile(string logText)
        {
            Debug.WriteLine("WEATHER SERVICE: " + logText);
        }
    }
}
