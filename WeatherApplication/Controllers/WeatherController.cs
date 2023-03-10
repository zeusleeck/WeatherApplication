using System;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;
using WeatherApplication.Data;
using WeatherApplication.Models;
using WeatherApplication.Services;
using WeatherApplication.Models;
using WeatherApplication.Services;


namespace WeatherApplication.Controllers
{
    public class WeatherController : Controller
    {
        private readonly WeatherContext _db;
        private readonly ILogger<WeatherController> _logger;
        public WeatherController(WeatherContext db, ILogger<WeatherController> logger)
        {
            _db = db;
            _logger = logger;
        } 

        public IActionResult Index()
        {
            WeatherServices weatherServices = new WeatherServices(_db,_logger);
            int? firstCityId = weatherServices.getFirstCityId();
            string firstUnit = weatherServices.getFirstUnit();
            WeatherList objWeatherList = weatherServices.getWeatherbyCity(weatherServices.getFirstCityId(), weatherServices.getFirstUnit());
            var cities = weatherServices.getCitySelectListItem(objWeatherList, firstCityId.ToString());
            var metrics = weatherServices.getMetricSelectListItem(firstUnit);

            ViewBag.cities = cities;
            ViewBag.metrics = metrics;

            return View(objWeatherList);
        }

        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {

            string SelectedCity = form["cities_ddl"];
            string Metric = form["metrics_ddl"];
            string DateFrom = form["date_from"];
            string Dateto = form["date_to"];

            WeatherServices weatherServices = new WeatherServices(_db, _logger);
            WeatherList objWeatherList = weatherServices.getCityWeather(SelectedCity, Metric, DateFrom, Dateto);

            var cities = weatherServices.getCitySelectListItem(objWeatherList, SelectedCity);
            var metrics = weatherServices.getMetricSelectListItem(Metric);

            ViewBag.cities = cities;
            ViewBag.metrics = metrics;
            return View(objWeatherList);
        }

        [HttpGet]
        public async Task<ActionResult<string>> getHottestCity()
        {
            WeatherServices weatherServices = new WeatherServices(_db, _logger);
            var hottestCity = await weatherServices.getHottestCity();
            return JsonSerializer.Serialize(hottestCity);
        }


        [HttpGet]
        public async Task<ActionResult<string>> getCityHighestHumidity()
        {
            WeatherServices weatherServices = new WeatherServices(_db, _logger);
            var CityHighestHumidity = await weatherServices.getCityWithHigestHumidity();
            return JsonSerializer.Serialize(CityHighestHumidity);
        }
    }
}
