using Microsoft.EntityFrameworkCore;
using СarsharingWebApp.Model.Entity;

namespace СarsharingWebApp.Model
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<CarOwner> CarOwner { get; set; }

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
