using Microsoft.EntityFrameworkCore;
using СarsharingWebApp.Model.Entity;

namespace СarsharingWebApp.Model
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<CarOwner> CarOwner { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<CarBrand> CarBrand { get; set; }
        public DbSet<CarModel> CarModel { get; set; }
        public DbSet<CarCondition> CarCondition { get; set; }
        public DbSet<OrderCost> OrderCost { get; set; }
        public DbSet<OrderRate> OrderRate { get; set; }
        public DbSet<CarServ> CarServ { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<Order> Order { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
