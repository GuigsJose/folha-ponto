using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace FolhaPontoApi.data
{
    public class FolhaPontoDbContextFactory : IDesignTimeDbContextFactory<FolhaPontoDbContext>
    {
        public FolhaPontoDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FolhaPontoDbContext>();

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8,0,36)));

            return new FolhaPontoDbContext(optionsBuilder.Options);
        }
    }
}