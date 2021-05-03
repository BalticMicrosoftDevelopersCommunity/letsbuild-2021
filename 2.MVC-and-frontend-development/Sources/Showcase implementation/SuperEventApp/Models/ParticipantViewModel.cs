using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperEventApp.Models
{
    public class ParticipantViewModel
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Email { get; set; }

        [Range(0, 150, ErrorMessage = "Please enter a believable value for your Age")]
        public int Age { get; set; }
    }
}
