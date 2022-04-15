using UrlShortner.Core.Contracts.Urls;
using UrlShortner.Core.Domain;

namespace UrlShortner.Core.ApplicationServices.Urls.Commands.Shorter
{
    public class ShorterService : IShorterService
    {
        private readonly IUrlRepository urlCommandRepository;

        public ShorterService(IUrlRepository urlCommandRepository)
        {
            this.urlCommandRepository = urlCommandRepository;
        }

        public ShorterServiceOutput Execute(ShorterServiceInput input)
        {
            var shortUrl = input.LongURLPath.Substring(0, 3);
            var url = new URL()
            {
                ShortPath = shortUrl,
                LongPath = input.LongURLPath
            };
            urlCommandRepository.AddToDb(url);
            return new ShorterServiceOutput()
            {

                Value = shortUrl
            };
        }
    }
}
