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
            
            if (string.IsNullOrEmpty(input.value))
            {
                throw new ArgumentNullException();
            }

            string shortUrl = UrlShortner(input);
            
            var url = new URL()
            {
                ShortPath = shortUrl,
                LongPath = input.value
            };
            urlCommandRepository.AddToDb(url);

            return new ShorterServiceOutput()
            {

                Value = shortUrl
            };
        }

        private static string UrlShortner(ShorterServiceInput input)
        {
            return input.value.Substring(0, 3);
        }
    }
}
