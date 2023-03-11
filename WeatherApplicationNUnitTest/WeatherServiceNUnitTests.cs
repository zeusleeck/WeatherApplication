using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using WeatherApplication;
using WeatherApplication.Controllers;
using WeatherApplication.Data;
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
            var data = new List<Variable>
            {
                new Variable { Id = 1, Name= "Tempurature", Value="20.0", Timestamp = "2023-01-01 00:00:00.0000000 +00:00", CityId = 1},
                new Variable { Id = 1, Name= "Tempurature", Value="20.0", Timestamp = "2023-01-01 00:00:00.0000000 +00:00", CityId = 1},
                new Variable { Id = 1, Name= "Tempurature", Value="20.0", Timestamp = "2023-01-01 00:00:00.0000000 +00:00", CityId = 2},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Variable>>();
            mockSet.As<IQueryable<Variable>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Variable>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Variable>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Variable>>().Setup(m => m.GetEnumerator()).Returns(() => data.GetEnumerator());

            var mockContext = new Mock<WeatherContext>();
            mockContext.Setup(c => c.Variable).Returns(mockSet.Object);

            var service = _weatherServices(mockContext);

            var result = service.getFirstCityId();
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
