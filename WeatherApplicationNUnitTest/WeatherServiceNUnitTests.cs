using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System.Reflection.Metadata;
using WeatherApplication.Data;
using WeatherApplication.Models;
using WeatherApplication.Services;

namespace WeatherApplication
{
    [TestFixture]
    public class WeatherServiceNUnitTests
    {
        private readonly ILogger<WeatherServices> _logger;

        public Mock<WeatherContext> insertDbContext()
        {
            var variableData = new List<Variable>()
            {
                new Variable { Id = 1, Name= "Tempurature", Unit= "°C", Value="20.0", Timestamp = new DateTime(2023,1,1,00,00,00), CityId = 1},
                new Variable { Id = 2, Name= "Tempurature", Unit= "°C", Value="17.3", Timestamp = new DateTime(2023,1,2,00,00,00), CityId = 1},
                new Variable { Id = 92, Name= "Tempurature", Unit="°F", Value="86", Timestamp = new DateTime(2023,1,30,00,00,00), CityId = 2}
            }.AsQueryable();

            var cityData = new List<City>()
            {
                new City { Id = 1, CityName = "Singapore"},
                new City { Id = 1, CityName = "Singapore" } ,
                new City { Id = 2, CityName = "Kuala Lumpur"}
            }.AsQueryable();


            var mockSetVariable = new Mock<DbSet<Variable>>();
            mockSetVariable.As<IQueryable<Variable>>().Setup(m => m.Provider).Returns(variableData.Provider);
            mockSetVariable.As<IQueryable<Variable>>().Setup(m => m.Expression).Returns(variableData.Expression);
            mockSetVariable.As<IQueryable<Variable>>().Setup(m => m.ElementType).Returns(variableData.ElementType);
            mockSetVariable.As<IQueryable<Variable>>().Setup(m => m.GetEnumerator()).Returns(() => variableData.GetEnumerator());

            var mockVariableContext = new Mock<WeatherContext>();
            mockVariableContext.Setup(c => c.Variable).Returns(mockSetVariable.Object);

            /*var mockSetCity = new Mock<DbSet<City>>();
            mockSetCity.As<IQueryable<City>>().Setup(m => m.Provider).Returns(variableData.Provider);
            mockSetCity.As<IQueryable<City>>().Setup(m => m.Expression).Returns(variableData.Expression);
            mockSetCity.As<IQueryable<City>>().Setup(m => m.ElementType).Returns(variableData.ElementType);
            mockSetCity.As<IQueryable<City>>().Setup(m => m.GetEnumerator()).Returns(() => variableData.GetEnumerator());*/

            //var mockCityContext = new Mock<WeatherContext>();
            //mockCityContext.Setup(c => c.City).Returns(mockSetCity.Object);
            return mockVariableContext;
        }

        [Test]
        public void getFirstCityId()
        {
            var mockContext = insertDbContext();
            IWeatherServices weatherServices = new WeatherServices(mockContext.Object, _logger);

            var result = weatherServices.getFirstCityId();
            Assert.AreEqual(1,result);
        }

        [Test]
        public void getFirstUnit()
        {
            var mockContext = insertDbContext();
            IWeatherServices weatherServices = new WeatherServices(mockContext.Object, _logger);
            var result = weatherServices.getFirstUnit();
            Assert.AreEqual("Tempurature", result);
        }

        [Test]
        [TestCase("Singapore", "°C", "2023-02-14", "2023-02-18")]
        public void getCityWeather(string selectedCity, string Metric, string DateFrom, string DateTo)
        {
            var mockContext = insertDbContext();
            IWeatherServices weatherServices = new WeatherServices(mockContext.Object, _logger);
            var result = weatherServices.getCityWeather(selectedCity, Metric, DateFrom, DateTo);
            Assert.AreEqual(null, result);
        }

        [Test]
        public void getHottestCity()
        {
            var mockContext = insertDbContext();
            IWeatherServices weatherServices = new WeatherServices(mockContext.Object, _logger);
            var result = weatherServices.getHottestCity();
            Assert.AreEqual(new HottestCity { CityName= "Kuala Lumpur", NumberofDays=12 }, result);
        }


        [Test]
        public void getCityWithHigestHumidity()
        {
            var mockContext = insertDbContext();
            IWeatherServices weatherServices = new WeatherServices(mockContext.Object, _logger);
            var result = weatherServices.getCityWithHigestHumidity();
            Assert.AreEqual(new HigestHumidity { CityName = "Singapore", AverageHumidity = 66.06 }, result);
        }

        [Test]
        [TestCase("Temperature")]
        public void getMetricSelectListItem(string unit)
        {
           var mockContext = insertDbContext();
           IWeatherServices weatherServices = new WeatherServices(mockContext.Object, _logger);
           List<SelectListItem> metricSelectListItem = new List<SelectListItem>();
           metricSelectListItem.Add((new SelectListItem { Value = "Temperature", Text = "Temperature °C", Selected = true }));
           metricSelectListItem.Add((new SelectListItem { Value = "Humidity", Text = "Humidity %", Selected = false }));
           var result = weatherServices.getMetricSelectListItem(unit);
           Assert.AreEqual(metricSelectListItem, result);
        }
    }
}
