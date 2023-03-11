using Microsoft.AspNetCore.Mvc.Rendering;
using WeatherApplication.Models;

namespace WeatherApplication.Services
{
    public interface IWeatherServices
    {
        public int? getFirstCityId();
        public string getFirstUnit();

        public WeatherList getWeatherbyCity(int? city_id, string metric_unit);

        public WeatherList getCityWeather(string selectedCity, string Metric, string DateFrom, string DateTo);

        public Task<HottestCity> getHottestCity();


        public Task<HigestHumidity> getCityWithHigestHumidity();


        public List<SelectListItem> getCitySelectListItem(WeatherList objWeatherList, string SelectedCity);
        public List<SelectListItem> getMetricSelectListItem(string unit);
    }
}
