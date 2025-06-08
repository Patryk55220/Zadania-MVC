using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MovieAppMvc.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
