using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebReg.Data.Models;
using WebReg.Models;
using WebReg.Services;
using WebReg.Services.Models;

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
            var page = new PageModel();
            var persons = await personService.GetPageAsync(page);
            var model = BuildPersonsListViewModel(page, persons);

            return View("Persons", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ListPersonsForm(PageModel page)
        {
            var persons = await personService.GetPageAsync(page);
            var model = BuildPersonsListViewModel(page, persons);

            return View("Persons", model);
        }

        [HttpGet]
        public IActionResult AddPerson()
        {
            var model = new AddPersonViewModel();
            return View("AddPerson", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPersonForm(AddPersonViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("AddPerson", model);
            }

            return View("AddPerson", model);
        }

        private PersonsListViewModel BuildPersonsListViewModel(PageModel page, IReadOnlyList<Person> persons)
        {
            return new PersonsListViewModel
            {
                Page = page,
                Persons = mapper.Map<List<PersonViewModel>>(persons)
            };
        }
    }
}
