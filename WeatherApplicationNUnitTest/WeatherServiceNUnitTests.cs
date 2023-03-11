using Microsoft.AspNetCore.Mvc.Rendering;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApplication;
using WeatherApplication.Controllers;
using WeatherApplication.Models;
using WeatherApplication.Services;

namespace WeatherApplication
{

    [TestFixture]
    public class WeatherServiceNUnitTests
    {
        private readonly IWeatherServices _weatherServices;

        [Test]
        public void getFirstCityId()
        {
            var result = _weatherServices.getFirstCityId();
            Assert.AreEqual(1,result);
        }

        [Test]
        public void getFirstUnit()
        {
            var result = _weatherServices.getFirstUnit();
            Assert.AreEqual("Tempurature", result);
        }

        [Test]
        [TestCase(1, "Temperature")]
        public void getWeatherbyCity(int city_id, string metric_unit)
        {
            WeatherList result = _weatherServices.getWeatherbyCity(city_id, metric_unit);
           
            //var result = weatherList.getWeatherbyCity(city_id, metric_unit);

            Console.Write("Test");
            NUnit.Framework.TestContext.WriteLine(result);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void getCityWeather(string selectedCity, string Metric, string DateFrom, string DateTo)
        {
            Assert.AreEqual(0, 0);
        }

        [Test]
        public void getHottestCity()
        {
            Assert.AreEqual(0, 0);
        }


        [Test]
        public void getCityWithHigestHumidity()
        {
            Assert.AreEqual(0, 0);
        }

        [Test]
        public void getCitySelectListItem(WeatherList objWeatherList, string SelectedCity)
        {
            Assert.AreEqual(0, 0);
        }
        
        [Test]
        public void getMetricSelectListItem(string unit)
        {
            Assert.AreEqual(0, 0);
        }
    }
}
