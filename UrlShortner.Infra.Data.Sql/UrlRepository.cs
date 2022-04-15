using UrlShortner.Core.Contracts.Urls;
using UrlShortner.Core.Domain;

namespace UrlShortner.Infra.Data.Sql
{
    public class UrlRepository : IUrlRepository
    {
        private readonly UrlShortnerDbContext _dbContext;
        public UrlRepository(UrlShortnerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddToDb(URL url)
        {
            _dbContext.UrlTable.Add(url);
            _dbContext.SaveChanges();
        }

        public URL GetLongerUrlFromDb(string shorterUrl)
        {  
            var url =  _dbContext.UrlTable.Where(b => b.ShortPath == shorterUrl).First();
            return url;
        }
    }
}