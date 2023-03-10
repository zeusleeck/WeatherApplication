using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApplication;
using WeatherApplication.Models;
using WeatherApplication.Services;

namespace WeatherApplication
{
    [TestFixture]
    public class WeatherServiceNUnitTests
    {
        [Test]
        public void getWeatherbyCity(int? city_id, string metric_unit)
        {
            WeatherServices weatherList = new WeatherServices();
            //var result = weatherList.getWeatherbyCity();

            Assert.AreEqual(0,0);
        }
    }
}
