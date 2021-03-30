using System;
using System.Collections.Generic;

#nullable disable

namespace WebReg.Data.Models
{
    public partial class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Email { get; set; }
    }
}
