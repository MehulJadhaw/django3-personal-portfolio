using InfoApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace InfoApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }

        public DbSet<Value> Values { get; set; }

        public DbSet<Example> Examples { get; set; }

        public DbSet<Shipment> Shipments { get; set;} 
    }
}