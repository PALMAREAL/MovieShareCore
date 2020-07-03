using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.ViewModels
{
    public class DirectorViewModel : ViewModel
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
        [Display(Name = "País")]
        public string Country { get; set; }

        [Display(Name = "Conocido por")]
        public string Knowfor { get; set; }

        public IEnumerable<SelectListItem> Countries { get; set; }

        public string CountrySelected { get; set; }
    }
}
