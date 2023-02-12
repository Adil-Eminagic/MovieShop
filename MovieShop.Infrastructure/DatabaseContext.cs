
using Microsoft.EntityFrameworkCore;
using MovieShop.Core;

namespace MovieShop.Infrastructure
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieBuy> MovieBuys { get; set; }
        public DbSet<Photo> Photos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedData(modelBuilder);
            ApplyConfigurations(modelBuilder);
        }

    }
}
