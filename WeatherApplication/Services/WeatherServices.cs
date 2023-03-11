using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WeatherApplication.Controllers;
using WeatherApplication.Data;
using WeatherApplication.Models;
using static System.Net.Mime.MediaTypeNames;

namespace WeatherApplication.Services
{
    public class WeatherServices : IWeatherServices
    {
        private readonly WeatherContext _db;
        private readonly ILogger<WeatherController> _logger;

        public WeatherServices(WeatherContext db, ILogger<WeatherController> logger)
        {
            _db = db;
            _logger = logger;
        }
     
        public int? getFirstCityId()
        {
            var city_id = _db.Variable.First().CityId;
            return city_id;
        }

        public string getFirstUnit()
        {
            var metric_name = _db.Variable.First().Name;
            return metric_name;
        }

        public WeatherList getWeatherbyCity(int? city_id, string metric_unit)
        {
            WeatherList weatherList = new WeatherList();

            var VariableList = _db.Variable.Where(a => a.CityId == city_id).Where(a => a.Name == metric_unit);

            foreach (var obj in VariableList)
            {
                if (obj.Name == "Temperature" && obj.Unit == "°F")
                {
                    double Celsius = (Convert.ToDouble(obj.Value) - 32) * 5 / 9;
                    obj.Value = Celsius.ToString();
                }
            }
 
            IEnumerable<City> objCityList = _db.City;
            IEnumerable<Variable> objVariableList = VariableList;

            List<Chart> objChartList = new List<Chart>();

            if (objVariableList is not null && objCityList is not null)
            {
                foreach (var obj in objCityList)
                {
                    var cityId = obj.Id;
                    var cityName = obj.CityName;
                }

                foreach (var r in objVariableList)
                {
                    objChartList.Add(new Chart { x = r.Timestamp.ToString().Split()[0], y = Convert.ToDouble(r.Value) });
                }
            }


            weatherList.CityList = objCityList;
            weatherList.VariableList = objVariableList;
            weatherList.ChartList = objChartList;

            return weatherList;
        }

        public WeatherList getCityWeather(string selectedCity, string Metric, string DateFrom, string DateTo)
        {
            WeatherList weatherList = new WeatherList();
            IEnumerable<Variable> objVariableList = new List<Variable>();

            if (selectedCity is not null && Metric is not null && DateFrom != "" && DateTo != "")
            {
                objVariableList = _db.Variable.Where(a => a.CityId == Int32.Parse(selectedCity)).Where(a => a.Name == Metric).Where(x => x.Timestamp >= DateTimeOffset.Parse(DateFrom) && x.Timestamp <= DateTimeOffset.Parse(DateTo));

            }
            else if (selectedCity is not null && Metric is not null && DateFrom == "" && DateTo == "")
            {
                objVariableList = _db.Variable.Where(a => a.CityId == Int32.Parse(selectedCity)).Where(a => a.Name == Metric);
            }

            foreach (var obj in objVariableList)
            {
                if (obj.Name == "Temperature" && obj.Unit == "°F")
                {
                    double Celsius = (Convert.ToDouble(obj.Value) - 32) * 5 / 9;
                    obj.Value = Celsius.ToString();
                }
            }

            IEnumerable<City> objCityList = _db.City;
          

            List<Chart> objChartList = new List<Chart>();

            if (objVariableList is not null && objCityList is not null)
            {
                foreach (var obj in objCityList)
                {
                    var cityId = obj.Id;
                    var cityName = obj.CityName;
                }

                foreach (var r in objVariableList)
                {
                    objChartList.Add(new Chart { x = r.Timestamp.ToString().Split()[0], y = Convert.ToDouble(r.Value) });
                }
            }


            weatherList.CityList = objCityList;
            weatherList.VariableList = objVariableList;
            weatherList.ChartList = objChartList;

            return weatherList;
        }

        public async Task<HottestCity> getHottestCity()
        {
            HottestCity hottestCity = new HottestCity();
            var variableList = _db.Variable;

            IDictionary<string, int> cityNoOfDays = new Dictionary<string, int>();

            foreach (var obj in _db.City)
            {
                var cityId = obj.Id;
                var cityName = obj.CityName;
            }

            foreach (var obj in variableList)
            {
                if (obj.City?.CityName is not null)
                {
                    if (cityNoOfDays.Count != 0 && cityNoOfDays.ContainsKey(obj.City?.CityName))
                    {
                        if (obj.Name == "Temperature" && obj.Unit == "°C" && Convert.ToDouble(obj.Value) > 30.00)
                        {
                            cityNoOfDays[obj.City?.CityName] += 1;
                        }
                        else if (obj.Name == "Temperature" && obj.Unit == "°F" && Convert.ToDouble(obj.Value) > 30.00)
                        {
                            double Celsius = (Convert.ToDouble(obj.Value) - 32) * 5 / 9;
                            if (Celsius > 30.00)
                            {
                                cityNoOfDays[obj.City?.CityName] += 1;
                            }
                        }
                    }
                    else
                    {
                        if (obj.Name == "Temperature" && obj.Unit == "°C" && Convert.ToDouble(obj.Value) > 30.00)
                        {

                            cityNoOfDays.Add(obj.City.CityName, 1);

                        }
                        else if (obj.Name == "Temperature" && obj.Unit == "°F" && Convert.ToDouble(obj.Value) > 30.00)
                        {
                            double Celsius = (Convert.ToDouble(obj.Value) - 32) * 5 / 9;

                            if (Celsius > 30.00)
                            {
                                cityNoOfDays.Add(obj.City.CityName, 1);
                            }
                        }
                    }
                }
            }
            var cityOfMaxValue = cityNoOfDays.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

            hottestCity.CityName = cityOfMaxValue;
            hottestCity.NumberofDays = cityNoOfDays[cityOfMaxValue];

            return hottestCity;
        }


        public async Task<HigestHumidity> getCityWithHigestHumidity()
        {
            IDictionary<string, List<double>> cityHumidity = new Dictionary<string, List<double>>();

            List<HigestHumidity> higestHumiditiesList = new();

            var variableList = _db.Variable;

            foreach (var obj in _db.City)
            {
                var cityId = obj.Id;
                var cityName = obj.CityName;
            }

            foreach (var obj in variableList) {

                if (obj.City?.CityName is not null)
                {
                    if (cityHumidity.Count > 0 && cityHumidity.ContainsKey(obj.City?.CityName))
                    {
                        if (obj.Name == "Humidity" && cityHumidity.ContainsKey(obj.City?.CityName))
                        {
                            cityHumidity[obj.City?.CityName][0] += Convert.ToDouble(obj.Value);
                            cityHumidity[obj.City?.CityName][1] += 1;
                        }
                    }
                    else
                    {
                        if (obj.Name == "Humidity")
                        {
                            cityHumidity.Add(obj.City?.CityName, new List<double>{Convert.ToDouble(obj.Value), 1});
                        }
                    }
                }
            }



            foreach(var obj in cityHumidity)
            {
                var avghumidity = obj.Value[0] / obj.Value[1];
                higestHumiditiesList.Add(new HigestHumidity{ CityName = obj.Key, AverageHumidity = avghumidity });
            }


            var higestHumidity = higestHumiditiesList.MaxBy(val => val.AverageHumidity);

            return higestHumidity;
        }


        public List<SelectListItem> getCitySelectListItem(WeatherList objWeatherList, string SelectedCity)
        {
            List<SelectListItem> cities = new();

            if (objWeatherList.CityList is not null)
            {
                foreach (var item in objWeatherList.CityList)
                {
                    if (item.Id.ToString() == SelectedCity)
                    {
                        cities.Add(new SelectListItem { Value = item.Id.ToString(), Text = item.CityName, Selected = true });
                    }
                    else
                    {
                        cities.Add(new SelectListItem { Value = item.Id.ToString(), Text = item.CityName });
                    }
                }
            }
            return cities;
        }

        

        public List<SelectListItem> getMetricSelectListItem(string unit)
        {
            List<SelectListItem> metric = new();
            List<SelectListItem> distinctMetric = new ();
            if (_db.Variable is not null)
            {
                foreach (var item in _db.Variable)
                {
                    metric.Add(new SelectListItem { Value = item.Name, Text = item.Name + " " + item.Unit, Selected = false});

                }
            }
            distinctMetric = metric.GroupBy(x => x.Value).Select(x => x.First()).ToList();

            foreach (var item in distinctMetric)
            {
                if (item.Value.ToString() == unit)
                {
                    item.Selected = true;
                    
                }
            }
            return distinctMetric;
        }

        public List<string> getAvgMetric(WeatherList objWeatherList)
        {
            List<string> avgValueList = new List<string>();

            var avgValue = 0.0;
            if (objWeatherList.VariableList is not null && objWeatherList.CityList is not null)
            {
                double value = 0;

                foreach (var obj in objWeatherList.VariableList)
                {
                    value += double.Parse(obj.Value);
                }

                avgValue = Math.Ceiling(value / Convert.ToDouble(objWeatherList.VariableList.Count()));
                avgValueList.Add(objWeatherList.VariableList.FirstOrDefault()?.Name);
                avgValueList.Add(avgValue.ToString());
                avgValueList.Add(objWeatherList.VariableList.FirstOrDefault()?.Unit);

            }

            else
            {
                avgValueList.Add("No");
                avgValueList.Add("Data");
                avgValueList.Add("Avaliable");
            }

            return avgValueList;
        }
            
    }
}
