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

        public DbSet<City> City { get; set; }
        public DbSet<Variable> Variable { get; set; }
    }
}
