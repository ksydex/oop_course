using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ApplicationContext : DbContext
    {
        
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Stop> Stops { get; set; }
        public DbSet<Route2Stop> Route2Stops { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
    }
}