using Microsoft.EntityFrameworkCore;
using WeatherApplication.Models;

namespace WeatherApplication.Data
{
    public partial class WeatherContext : DbContext
    {
        public WeatherContext()
        {
        }

        public WeatherContext(DbContextOptions<WeatherContext> options): base(options)
        {
        }

        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Variable> Variable { get; set; }
    }
}
