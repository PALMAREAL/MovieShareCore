using Microsoft.AspNetCore.Mvc.Rendering;
using MovieShareCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.ViewModels
{
    public class MovieViewModel : ViewModel<Movie>
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(50, MinimumLength = 1,
        ErrorMessage = " The Title should be a maximum of 50 characters")]
        [Display(Name = "Título")]
        public string Title { get; set; }

        [StringLength(50, MinimumLength = 1,
             ErrorMessage = " The name should be a maximum of 40 characters")]
        [Display(Name = "Director")]
        public Director Director { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        public int DirectorId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Año")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Duración")]
        public int Duration { get; set; }

        [Display(Name = "Género")]
        public Genre Genre { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Género")]
        public int GenreId { get; set; }

        [Display(Name = "País")]
        public Country Country { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        public int CountryId { get; set; }

        [Display(Name = "Presupuesto")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public int? Budget { get; set; }

        public IEnumerable<SelectListItem> Directors { get; set; }

        public string DirectorSelected { get; set; }

        public IEnumerable<SelectListItem> Countries { get; set; }

        public string CountrySelected { get; set; }

        public IEnumerable<SelectListItem> Genres { get; set; }

        public string GenreSelected { get; set; }
    }
}
