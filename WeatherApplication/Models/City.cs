using System.ComponentModel.DataAnnotations;

namespace WeatherApplication.Models;

public class City
{
    public int Id { get; set; }

    public string CityName { get; set; } = null!;

    public virtual ICollection<Variable> Variable { get; } = new List<Variable>();
}
