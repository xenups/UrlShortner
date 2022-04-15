using Microsoft.EntityFrameworkCore;
using UrlShortner.Core.Domain;

namespace UrlShortner.Infra.Data.Sql
{
    public class UrlShortnerDbContext : DbContext
    {
        public UrlShortnerDbContext(DbContextOptions<UrlShortnerDbContext> options) : base(options) { }

        public DbSet<URL> UrlTable { get; set; }
    }

}
