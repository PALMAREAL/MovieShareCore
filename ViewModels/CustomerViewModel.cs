using Microsoft.AspNetCore.Mvc.Rendering;
using MovieShareCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.ViewModels
{
    public class CustomerViewModel : ViewModel<Customer>
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(50, MinimumLength = 1,
           ErrorMessage = " The Name should be a maximum of 40 characters")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Nacido")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Correo")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "País")]
        public string Country { get; set; }

        [Display(Name = "Admin")]
        public bool Admin { get; set; }

        public IEnumerable<SelectListItem> Countries { get; set; }

        public string CountrySelected { get; set; }
    }
}
