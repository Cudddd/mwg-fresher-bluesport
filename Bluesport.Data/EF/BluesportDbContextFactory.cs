using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Bluesport.Data.EF
{
    public class BluesportDbContextFactory : IDesignTimeDbContextFactory<BluesportDbContext>
    {
        public BluesportDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("BluesportDatabase");
            
            var optionsBuilder = new DbContextOptionsBuilder<BluesportDbContext>();
            optionsBuilder.UseNpgsql(connectionString);

            return new BluesportDbContext(optionsBuilder.Options);
        }
    }
}