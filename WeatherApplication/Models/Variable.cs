using System;
using System.Collections.Generic;

namespace WeatherApplication.Models;

public class Variable
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Unit { get; set; } = null!;

    public string Value { get; set; } = null!;

    public DateTimeOffset Timestamp { get; set; }

    public int? CityId { get; set; }

    public virtual City? City { get; set; }
}
