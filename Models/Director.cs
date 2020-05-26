using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.Models
{
    public class Director
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        public DateTime Birthdate { get; set; }

        [Display(Name = "País")]
        public string Country { get; set; }

        [Display(Name = "Conocido por")]
        public string Knowfor { get; set; }
    }
}
