using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Reflection;

namespace Marco.CleanArchitecture.Infrastructure.EntityFrameworkDataAccess
{
    public sealed class DataAccessEntityFrameworkContextFactory : IDesignTimeDbContextFactory<DataAccessEntityFrameworkContext>
    {
        public DataAccessEntityFrameworkContext CreateDbContext(string[] args)
        {

            var builder = new DbContextOptionsBuilder<DataAccessEntityFrameworkContext>();
            builder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CleanArchitectureDataBase;Trusted_Connection=True;MultipleActiveResultSets=true",
                optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(DataAccessEntityFrameworkContext).GetTypeInfo().Assembly.GetName().Name));

            return new DataAccessEntityFrameworkContext(builder.Options);
        }
    }
}