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
        private readonly ILogger<WeatherController> _logger;
        private readonly IWeatherServices _weatherServices;
        public WeatherController(IWeatherServices weatherServices)
        {
            _weatherServices = weatherServices;
        } 

        public IActionResult Index()
        {
            int? firstCityId = _weatherServices.getFirstCityId();
            string firstUnit = _weatherServices.getFirstUnit();

            WeatherList objWeatherList = _weatherServices.getWeatherbyCity(_weatherServices.getFirstCityId(), _weatherServices.getFirstUnit());
            var cities = _weatherServices.getCitySelectListItem(objWeatherList, firstCityId.ToString());
            var metrics = _weatherServices.getMetricSelectListItem(firstUnit);
            var avgTemp = _weatherServices.getAvgMetric(objWeatherList);

            ViewBag.cities = cities;
            ViewBag.metrics = metrics;
            ViewBag.avgTemp = avgTemp;
            return View(objWeatherList);
        }

        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {

            string SelectedCity = form["cities_ddl"];
            string Metric = form["metrics_ddl"];
            string DateFrom = form["date_from"];
            string Dateto = form["date_to"];

            WeatherList objWeatherList = _weatherServices.getCityWeather(SelectedCity, Metric, DateFrom, Dateto);

            var cities = _weatherServices.getCitySelectListItem(objWeatherList, SelectedCity);
            var metrics = _weatherServices.getMetricSelectListItem(Metric);
            var avgTemp = _weatherServices.getAvgMetric(objWeatherList);

            ViewBag.cities = cities;
            ViewBag.metrics = metrics;
            ViewBag.avgTemp = avgTemp;
            return View(objWeatherList);
        }

        [HttpGet]
        public async Task<ActionResult<string>> getHottestCity()
        {
            var hottestCity = await _weatherServices.getHottestCity();
            return JsonSerializer.Serialize(hottestCity);
        }


        [HttpGet]
        public async Task<ActionResult<string>> getCityHighestHumidity()
        {
            var CityHighestHumidity = await _weatherServices.getCityWithHigestHumidity();
            return JsonSerializer.Serialize(CityHighestHumidity);
        }
    }
}
