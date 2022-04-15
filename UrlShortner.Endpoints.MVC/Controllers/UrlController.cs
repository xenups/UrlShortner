using Microsoft.AspNetCore.Mvc;
using UrlShortner.Core.Contracts.Urls;

namespace UrlShortner.Endpoints.MVC.Controllers
{
    public class UrlController : Controller
    {
        private readonly IShorterAppService _shorterService;
        public UrlController(IShorterAppService shorterService)
        {
            _shorterService = shorterService;
        }

        [HttpGet]
        public IActionResult ShortnerURL([FromQuery] string longURLPath)
        {
            var serviceInut = new ShorterServiceInput() { LongURLPath = longURLPath };
            var shorterServiceOutput = _shorterService.Execute(serviceInut);

            return base.Ok(shorterServiceOutput.Value);
        }
    }
}
