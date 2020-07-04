using Microsoft.AspNetCore.Mvc.Rendering;
using MovieShareCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShareCore.ViewModels.Factory
{
    public class MovieViewModelFactory : ViewModelFactory
    {
        private IDirectorService DirectorService;

        public MovieViewModelFactory(IDirectorService directorService)
        {
            DirectorService = directorService;
        }

        public override ViewModel Create()
        {
            var directors = DirectorService.GetAll()
                .Result
                .Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name });

            var countries = DirectorService.GetCountries()
                .Result
                .Select(x => new SelectListItem { Value = x.Code.ToString(), Text = x.Name });

            return new MovieViewModel
            { 
                Directors = directors,
                Countries = countries
            };
        }
    }
}
