using Marco.CleanArchitecture.Infrastructure.EntityFrameworkDataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Marco.CleanArchitecture.Infrastructure.EntityFrameworkDataAccess
{
    public class DataAccessEntityFrameworkContext : DbContext
    {
        public DataAccessEntityFrameworkContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .ToTable("Products");

            base.OnModelCreating(modelBuilder);
        }
    }
}