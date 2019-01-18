using Sample.MovieCatalogue.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Sample.MovieCatalogue.Data
{
    public class MovieCatalogueDbContext : DbContext
    {
        public MovieCatalogueDbContext(DbContextOptions<MovieCatalogueDbContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(new[]
                {
                    new Movie { Title = "The Matrix", ReleaseYear = 1999 },
                    new Movie { Title = "Shrek", ReleaseYear = 2001 },
                    new Movie { Title = "Inception", ReleaseYear = 2010 },
                    new Movie { Title = "Glass", ReleaseYear = 2019 },
                    new Movie { Title = "Glengarry Glen Ross", ReleaseYear = 1992 },
                    new Movie { Title = "Dunkirk", ReleaseYear = 2017 },
                });
        }
    }
}