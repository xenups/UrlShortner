using UrlShortner.Core.ApplicationServices.Urls.Commands.Shorter;

namespace UrlShortner.Core.Contracts.Urls
{
    public interface IShorterAppService
    {
        ShorterServiceOutput Execute(ShorterServiceInput shorterCommand);
    }
}