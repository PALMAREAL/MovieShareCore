using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Display(Name = "Nacido")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Birthdate { get; set; }

        [Display(Name = "Correo")]
        public string Mail { get; set; }

        [Display(Name = "País")]
        public string Country { get; set; }

        [Display(Name = "Admin")]
        public bool Admin { get; set; }
    }
}
