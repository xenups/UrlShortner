using UrlShortner.Core.ApplicationServices.Urls.Commands.Shorter;

namespace UrlShortner.Core.Contracts.Urls
{
    public interface IShorterService
    {
        ShorterServiceOutput Execute(ShorterServiceInput shorterCommand);
    }
}