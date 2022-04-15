using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace UrlShortner.Infra.Data.Sql
{
    public class UrlShortnerDbContextFactory : IDesignTimeDbContextFactory<UrlShortnerDbContext>
    {
        public UrlShortnerDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<UrlShortnerDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ContosoUniversity1;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new UrlShortnerDbContext(optionsBuilder.Options);
        }
    }
}
