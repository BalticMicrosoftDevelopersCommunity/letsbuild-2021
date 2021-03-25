using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using WebReg.Services;

namespace WebReg.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> logger;
        private readonly IPersonService personService;

        public HomeController(
            ILogger<HomeController> logger,
            IPersonService personService)
        {
            this.logger = logger;
            this.personService = personService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Persons()
        {
            var persons = await personService.ListAllAsync();

            return View("Persons", persons);
        }
    }
}
