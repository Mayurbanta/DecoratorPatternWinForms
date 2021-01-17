using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherCompoment.Contracts;
using WeatherCompoment.Service;

namespace UILayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowWeather_Click(object sender, EventArgs e)
        {
            IWeatherService weatherService = WeatherService();

            var currentWeather = weatherService.GetCurrentWeather("Bangalore");
            lblTemp.Text = currentWeather.Temperature.ToString();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblTemp.Text = "Load temperature...";
        }

        private IWeatherService WeatherService()
        {
            Ilogger logger = new LoggerService();
            ICache cache = new CacheService();

            IWeatherService concreteWeather = new WeatherService();
            IWeatherService withLoggingDecorator = new WeatherServiceLoggingDecorator(concreteWeather, logger);
            IWeatherService withCachingDecorator = new WeatherServiceCachingDecorator(withLoggingDecorator, cache);

            return withCachingDecorator;
        }
    }
}
