using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebReg.Models
{
    public class AddPersonViewModel
    {
        [DisplayName("First Name")]
        [Required(ErrorMessage = "Please enter a First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Please enter a Last Name")]
        public string LastName { get; set; }

        [DisplayName("Birth Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }

        [DisplayName("Email Address")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please enter a valid email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
