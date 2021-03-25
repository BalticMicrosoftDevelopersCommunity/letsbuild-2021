using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebReg.Models
{
    public class PersonViewModel
    {
        public Guid Id { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Birth Date")]
        public string BirthDate { get; set; }

        [DisplayName("Email Address")]
        public string Email { get; set; }
    }
}
