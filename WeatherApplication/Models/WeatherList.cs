namespace WeatherApplication.Models

{
    public class WeatherList
    {
        public IEnumerable<City>? CityList;

        public IEnumerable<Variable>? VariableList;

        public List<Chart>? ChartList;
    }
}
