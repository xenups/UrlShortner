using UrlShortner.Core.Contracts.Urls;

namespace UrlShortner.Core.ApplicationServices.Urls
{
    public interface ILongerAppService
    {
        LongerServiceOutput Execute(LongerServiceInput longerServiceInput);
    }
}