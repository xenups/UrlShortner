using UrlShortner.Core.Domain;

namespace UrlShortner.Core.Contracts.Urls
{
    public interface IUrlRepository
    {
        void AddToDb(URL url);
        URL GetLongerUrlFromDb(string shortUrl);
    }

}