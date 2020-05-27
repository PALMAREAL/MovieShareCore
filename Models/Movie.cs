using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "Título")]
        public string Title { get; set; }

        [Display(Name = "Director")]
        public string Director { get; set; }

        [Display(Name = "Año")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy}")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Duración")]
        public int Duration { get; set; }

        [Display(Name = "Género")]
        public Genre Genre { get; set; }

        [Display(Name = "Género")]
        public int GenreId { get; set; }

        [Display(Name = "País")]
        public string Country { get; set; }

        [Display(Name = "Presupuesto")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public int? Budget { get; set; }
    }
}
