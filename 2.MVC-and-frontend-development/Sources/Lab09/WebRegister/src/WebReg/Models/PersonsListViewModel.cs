using System.Collections.Generic;

namespace WebReg.Models
{
    public class PersonsListViewModel
    {
        public PageViewModel Page { get; set; }

        public List<PersonViewModel> Persons { get; set; }

        public PersonsListViewModel()
        {
            Page = new PageViewModel();
            Persons = new List<PersonViewModel>();
        }
    }
}
