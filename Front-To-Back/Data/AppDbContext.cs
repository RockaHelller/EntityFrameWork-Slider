using Front_To_Back.Models;
using Microsoft.EntityFrameworkCore;

namespace Front_To_Back.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Strategy> Strategies { get; set; }

    }
}
