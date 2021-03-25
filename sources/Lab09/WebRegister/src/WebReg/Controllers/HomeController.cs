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
            var model = new PersonsListViewModel
            {
                Persons = mapper.Map<List<PersonViewModel>>(persons)
            };

            return View("Persons", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ListPersonsForm(PageViewModel page)
        {
            var persons = await personService.GetPageAsync(page.SortColumn, page.SortOrder);
            var model = new PersonsListViewModel
            {
                Page = page,
                Persons = mapper.Map<List<PersonViewModel>>(persons)
            };

            return View("Persons", model);
        }
    }
}
