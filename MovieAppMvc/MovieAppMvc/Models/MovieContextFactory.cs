using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace MovieAppMvc.Models
{
    public class MovieContextFactory : IDesignTimeDbContextFactory<MovieContext>
    {
        public MovieContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<MovieContext>();
            var connectionString = configuration.GetConnectionString("MovieContext");
            builder.UseSqlite(connectionString);

            return new MovieContext(builder.Options);
        }
    }
}
