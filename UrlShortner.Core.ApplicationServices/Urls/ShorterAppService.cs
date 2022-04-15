using UrlShortner.Core.Contracts.Urls;
using UrlShortner.Core.Domain;

namespace UrlShortner.Core.ApplicationServices.Urls.Commands.Shorter
{
    public class ShorterAppService : IShorterAppService
    {
        private readonly IUrlRepository urlCommandRepository;

        public ShorterAppService(IUrlRepository urlCommandRepository)
        {
            this.urlCommandRepository = urlCommandRepository;
        }

        public ShorterServiceOutput Execute(ShorterServiceInput input)
        {
            string shortUrl = UrlShortner(input);
            
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

        private static string UrlShortner(ShorterServiceInput input)
        {
            return input.LongURLPath.Substring(0, 3);
        }
    }
}
