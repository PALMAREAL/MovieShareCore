using Microsoft.AspNetCore.Mvc.Rendering;
using MovieShareCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.ViewModels
{
    public class MovieViewModel : ViewModel
    {
        public int Id { get; set; }


        public string Title { get; set; }

  
        public string Director { get; set; }


        public DateTime ReleaseDate { get; set; }


        public int Duration { get; set; }


        public Genre Genre { get; set; }


        public int GenreId { get; set; }


        public string Country { get; set; }


        public int? Budget { get; set; }

        public IEnumerable<SelectListItem> Directors { get; set; }

        public string DirectorSelected { get; set; }
    }
}
