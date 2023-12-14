using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class MyDatabaseContext : DbContext
    {
        public DbSet<Movie> DBMovies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDb");
        }
    }
}
