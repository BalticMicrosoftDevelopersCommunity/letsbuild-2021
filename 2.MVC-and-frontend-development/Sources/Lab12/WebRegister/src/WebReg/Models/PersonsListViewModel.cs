using System.Collections.Generic;
using WebReg.Services.Models;

namespace WebReg.Models
{
    public class PersonsListViewModel
    {
        public PageModel Page { get; set; }

        public List<PersonViewModel> Persons { get; set; }

        public PersonsListViewModel()
        {
            Page = new PageModel();
            Persons = new List<PersonViewModel>();
        }
    }
}
