using Microsoft.AspNetCore.Mvc;
using UrlShortner.Core.ApplicationServices.Urls;
using UrlShortner.Core.Contracts.Urls;

namespace UrlShortner.Endpoints.MVC.Controllers
{
    public class UrlController : Controller
    {
        private readonly IShorterAppService _shorterService;
        private readonly ILongerAppService _longerService;
        public UrlController(IShorterAppService shorterService, ILongerAppService longerAppService)
        {
            _shorterService = shorterService;
            _longerService = longerAppService;
        }

        [HttpGet]
        public IActionResult ShortnerURL([FromQuery] string longURLPath)
        {
            var serviceInut = new ShorterServiceInput() { value = longURLPath };
            var shorterServiceOutput = _shorterService.Execute(serviceInut);

            return base.Ok(shorterServiceOutput.Value);
        }
        [HttpGet]
        public IActionResult LongerURL([FromQuery] string shortURLPath)
        {
            var serviceInput = new LongerServiceInput() { value = shortURLPath };
            var longerServiceOutput = _longerService.Execute(serviceInput);
            return base.Ok(longerServiceOutput.value);

        }
    }
}
