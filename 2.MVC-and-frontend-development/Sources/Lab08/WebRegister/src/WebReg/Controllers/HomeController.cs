using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebReg.Models;
using WebReg.Services;

namespace WebReg.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> logger;
        private readonly IPersonService personService;
        private readonly IMapper mapper;

        public HomeController(
            ILogger<HomeController> logger,
            IMapper mapper,
            IPersonService personService)
        {
            this.logger = logger;
            this.mapper = mapper;
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
            var model = mapper.Map<List<PersonViewModel>>(persons);

            return View("Persons", model);
        }
    }
}
