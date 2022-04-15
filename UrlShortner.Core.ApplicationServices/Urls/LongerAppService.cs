using UrlShortner.Core.Contracts.Urls;
using UrlShortner.Core.Domain;

namespace UrlShortner.Core.ApplicationServices.Urls
{
    public class LongerAppService : ILongerAppService
    {
        private readonly IUrlRepository _urlRepository;
        public LongerAppService(IUrlRepository urlRepository)
        {
            _urlRepository = urlRepository;
        }

        public LongerServiceOutput Execute(LongerServiceInput shorterServiceInput)
        {   
            URL url = this._urlRepository.GetLongerUrlFromDb(shorterServiceInput.value);
            LongerServiceOutput longUrl = new LongerServiceOutput { value = url.LongPath };
            return longUrl;
        }
    }
}
